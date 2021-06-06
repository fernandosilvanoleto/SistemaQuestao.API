using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaQuestao.Core.Entities;
using System;

namespace SistemaQuestao.Infrastructure.Persistence.Configurations
{
    public class AssuntoConfigurations : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .HasOne(a => a.Disciplina)  // UM ASSUNTO SOMENTE TEM UMA DISCIPLINA PARA SE RELACIONAR NESSE MODELO => ATRIBUTO "Disciplina" É UM ATRIBUTO DE NAVEGAÇÃO => FIZ NA TABELA Assunto
                .WithMany(disc => disc.Assuntos) // AGORA, UMA DISCIPLINA PODE TER VÁRIOS ASSUNTOS => FAZ RELAÇÃO COM A TABELA DE "Assunto"
                .HasForeignKey(ass => ass.IdDisciplina) // CHAVE ESTRANGEIRA DE DISCIPLINA EM ASSUNTO
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(ass => ass.AssuntoPai)
                .WithMany(ass => ass.AssuntoPaiList)
                .HasForeignKey(ass => ass.IdAssuntoPai)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
