using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaQuestao.Core.Entities
{
    public class Area : BaseEntity
    {
        public Area(string nome, string? descricao)
        {
            Nome = nome;
            Descricao = descricao;

            DataCriacao = DateTime.Now;
        }

        // PROPRIEDADES/MÉTODOS
        [StringLength(80, MinimumLength =4, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string Nome { get; private set; }

        [Display(Name = "Descrição")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string? Descricao { get; private set; }

        [Display(Name = "Data Criação")]
        public DateTime DataCriacao { get; private set; }
        public List<AreaDisciplina> AreaDisciplinas { get; private set; }


        // MÉTODOS
        public void Update(string descricao)
        {
            Descricao = descricao;
        }


        //EVENTOS
    }
}
