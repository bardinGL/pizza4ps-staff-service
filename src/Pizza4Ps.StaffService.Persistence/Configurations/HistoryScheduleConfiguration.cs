using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Persistence.Constants;

namespace Pizza4Ps.StaffService.Persistence.Configurations
{
	public class HistoryScheduleConfiguration : IEntityTypeConfiguration<HistorySchedule>
	{
		public void Configure(EntityTypeBuilder<HistorySchedule> builder)
		{
			builder.ToTable(TableNames.HistorySchedule);
			builder.HasKey(x => x.Id);

			builder.Property(x => x.SchedualDate)
				.IsRequired();

			builder.Property(x => x.ShiftStart)
				.IsRequired();

			builder.Property(x => x.ShiftEnd)
				.IsRequired();

			builder.Property(x => x.Status)
				.IsRequired()
				.HasMaxLength(50);

			builder.Property(x => x.StaffId)
				.IsRequired();

			builder.HasOne(x => x.Staff)
				.WithMany()
				.HasForeignKey(x => x.StaffId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
