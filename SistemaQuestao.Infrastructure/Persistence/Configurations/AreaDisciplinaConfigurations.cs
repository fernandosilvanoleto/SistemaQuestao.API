using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaQuestao.Core.Entities;

namespace SistemaQuestao.Infrastructure.Persistence.Configurations
{
    public class AreaDisciplinaConfigurations : IEntityTypeConfiguration<AreaDisciplina>
    {
        public void Configure(EntityTypeBuilder<AreaDisciplina> builder)
        {
            builder
                .HasKey(ad => ad.Id);

            builder
                .HasOne(ad => ad.Area)
                .WithMany(area => area.AreaDisciplinas)
                .HasForeignKey(ad => ad.IdArea)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ad => ad.Disciplina)
                .WithMany(area => area.AreaDisciplinas)
                .HasForeignKey(ad => ad.IdDisciplina)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
