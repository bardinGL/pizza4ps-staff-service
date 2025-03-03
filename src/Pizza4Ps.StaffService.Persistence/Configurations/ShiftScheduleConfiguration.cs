using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Persistence.Constants;

namespace Pizza4Ps.StaffService.Persistence.Configurations
{
    public class ShiftScheduleConfiguration : IEntityTypeConfiguration<ShiftSchedule>
    {
        public void Configure(EntityTypeBuilder<ShiftSchedule> builder)
        {
            builder.ToTable(TableNames.ShiftSchedule);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ShiftStart)
                .IsRequired();

            builder.Property(x => x.ShiftEnd)
                .IsRequired();

            builder.HasOne(x => x.Staff)
                .WithMany()
                .HasForeignKey(x => x.StaffId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Day)
                .WithMany()
                .HasForeignKey(x => x.DayId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Shift)
                .WithMany()
                .HasForeignKey(x => x.ShiftId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
