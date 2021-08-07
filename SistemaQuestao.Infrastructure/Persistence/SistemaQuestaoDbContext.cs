using Microsoft.EntityFrameworkCore;
using SistemaQuestao.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SistemaQuestao.Infrastructure.Persistence
{
    public class SistemaQuestaoDbContext : DbContext
    {
        public SistemaQuestaoDbContext()
        {
        }

        public SistemaQuestaoDbContext(DbContextOptions<SistemaQuestaoDbContext> options) : base(options)
        {

        }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Assunto> Assuntos { get; set; }
        public DbSet<AreaDisciplina> AreaDisciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}