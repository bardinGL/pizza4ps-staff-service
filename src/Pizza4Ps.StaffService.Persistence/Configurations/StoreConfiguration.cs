using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Persistence.Constants;

namespace Pizza4Ps.StaffService.Persistence.Configurations
{
	public class StoreConfiguration : IEntityTypeConfiguration<Store>
	{
		public void Configure(EntityTypeBuilder<Store> builder)
		{
			builder.ToTable(TableNames.Store);
			builder.HasKey(x => x.Id);
		}
	}
}
