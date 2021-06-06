using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaQuestao.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Infrastructure.Persistence.Configurations
{
    public class DisciplinaConfigurations : IEntityTypeConfiguration<Disciplina>
    {
        public void Configure(EntityTypeBuilder<Disciplina> builder)
        {
            builder
                .HasKey(d => d.Id);
        }
    }
}
