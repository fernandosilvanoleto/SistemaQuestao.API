using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaQuestao.Core.Entities;

namespace SistemaQuestao.Infrastructure.Persistence.Configurations
{
    public class AreaConfigurations : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder
                .HasKey(a => a.Id);
        }
    }
}
