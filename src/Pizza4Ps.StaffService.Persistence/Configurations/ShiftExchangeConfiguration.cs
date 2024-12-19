using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizza4Ps.StaffService.Domain.Entities;
using Pizza4Ps.StaffService.Persistence.Constants;

namespace Pizza4Ps.StaffService.Persistence.Configurations
{
	public class ShiftExchangeConfiguration : IEntityTypeConfiguration<ShiftExchange>
	{
		public void Configure(EntityTypeBuilder<ShiftExchange> builder)
		{
			builder.ToTable(TableNames.ShiftExchange);
			builder.HasKey(x => x.Id);
		}
	}
}
