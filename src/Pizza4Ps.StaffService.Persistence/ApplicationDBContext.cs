﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pizza4Ps.StaffService.Domain.Abstractions.Entities;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Domain.Entities.Identity;
using Pizza4Ps.StaffService.Persistence.Intercepter;
using System.Linq.Expressions;

namespace Pizza4Ps.StaffService.Persistence
{
	public sealed class ApplicationDBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        private readonly AuditSaveChangesInterceptor _auditInterceptor;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, AuditSaveChangesInterceptor auditInterceptor)
            : base(options)
        {
            _auditInterceptor = auditInterceptor;
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            var softDeleteEntities = typeof(ISoftDelete).Assembly.GetTypes()
                .Where(type => typeof(ISoftDelete).IsAssignableFrom(type)
                && type.IsClass
                && !type.IsAbstract);
            foreach (var softDeleteEntity in softDeleteEntities)
            {
                builder.Entity(softDeleteEntity).HasQueryFilter(GenerateQueryFilterLambda(softDeleteEntity));
            }
            builder.ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);
        }

        private LambdaExpression? GenerateQueryFilterLambda(Type type)
        {
            var parameter = Expression.Parameter(type, "w");
            var falseConstantValue = Expression.Constant(false);
            var propertyAccess = Expression.PropertyOrField(parameter, nameof(ISoftDelete.IsDeleted));
            var equalExpression = Expression.Equal(propertyAccess, falseConstantValue);
            var lambda = Expression.Lambda(equalExpression, parameter);
            return lambda;
        }

        #region Configuration DbSet
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<HistorySchedule> HistorySchedules { get; set; }
		public DbSet<IndividualSchedule> IndividualSchedules { get; set; }
		public DbSet<ShiftExchange> ShiftExchanges { get; set; }
		public DbSet<Staff> Staffs { get; set; }
		public DbSet<Store> Stores { get; set; }
		#endregion
	}
}
