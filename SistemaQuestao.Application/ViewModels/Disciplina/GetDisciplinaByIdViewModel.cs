using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.ViewModels.Disciplina
{
    public class GetDisciplinaByIdViewModel
    {
        public GetDisciplinaByIdViewModel(int id, string nome, string complemento, DateTime dataCriacao)
        {
            Id = id;
            Nome = nome;
            Complemento = complemento;
            DataCriacao = dataCriacao;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string? Complemento { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
