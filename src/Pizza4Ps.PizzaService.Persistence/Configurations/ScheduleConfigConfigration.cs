﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pizza4Ps.PizzaService.Domain.Entities;
using Pizza4Ps.PizzaService.Persistence.Constants;

namespace Pizza4Ps.PizzaService.Persistence.Configurations
{
    public class ScheduleConfigConfigration : IEntityTypeConfiguration<ScheduleConfig>
    {
        public void Configure(EntityTypeBuilder<ScheduleConfig> builder)
        {
            builder.ToTable(TableNames.ScheduleConfig);
            builder.HasKey(x => x.Id);
        }
    }
}
