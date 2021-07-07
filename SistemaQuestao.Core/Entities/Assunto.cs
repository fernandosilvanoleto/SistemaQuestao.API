using SistemaQuestao.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaQuestao.Core.Entities
{
    public class Assunto : BaseEntity
    {
        public Assunto(string descricao, string? observacao, int idDisciplina, int? idAssuntoPai)
        {
            Descricao = descricao;
            Observacao = observacao;

            Status = AssuntoEnum.Ativo;

            IdDisciplina = idDisciplina;
            IdAssuntoPai = idAssuntoPai;

            AssuntoPaiList = new List<Assunto>();
        }

        [StringLength(80, MinimumLength = 4, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string Descricao { get; private set; }

        [StringLength(500, MinimumLength = 4, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string? Observacao { get; private set; }
        public AssuntoEnum Status { get; private set; }
        public int IdDisciplina { get; set; }
        public Disciplina Disciplina { get; private set; }
        public int? IdAssuntoPai { get; private set; }
        public Assunto AssuntoPai { get; set; }
        public List<Assunto> AssuntoPaiList { get; private set; }

        // MÉTODOS
        public void AdicionarAssuntoPaiById(int idPai)
        {
            if (idPai != 0)
            {
                this.IdAssuntoPai = idPai;
            }
        }

        public void Update(string descricao, string? observacao)
        {
            if (descricao != null)
            {
                this.Descricao = descricao;
                this.Observacao = observacao;
            }
        }

        public void UpdateAssuntoPaiRelacionada(int idAssuntoPai)
        {
            if (idAssuntoPai != 0)
            {
                this.IdAssuntoPai = idAssuntoPai;
            }
        }

        public string GetNomeAssuntoPai()
        {
            // AQUI FAÇO O TRATAMENTO CORRETO
            if (AssuntoPai == null)
            {
                return "";
            }
            return AssuntoPai.Descricao;            
        }
    }
}
