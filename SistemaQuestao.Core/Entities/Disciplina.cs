using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaQuestao.Core.Entities
{
    public class Disciplina : BaseEntity
    {
        public Disciplina(string nome, string? complemento)
        {
            Nome = nome;
            Complemento = complemento;

            DataCriacao = DateTime.Now;

            Assuntos = new List<Assunto>();
        }

        [StringLength(80, MinimumLength = 3, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string Nome { get; private set; }

        [StringLength(500, MinimumLength = 4, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string? Complemento { get; private set; }

        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; private set; }

        public List<AreaDisciplina> AreaDisciplinas { get; private set; }
        public List<Assunto> Assuntos { get; private set; }

        // MÉTODOS
        public void Update(string complemento)
        {
            if (complemento != null)
            {
                this.Complemento = complemento;
            }
        }
    }
}
