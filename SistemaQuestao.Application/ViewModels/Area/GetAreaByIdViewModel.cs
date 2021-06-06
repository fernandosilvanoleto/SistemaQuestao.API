using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.ViewModels.Area
{
    public class GetAreaByIdViewModel
    {
        public GetAreaByIdViewModel(int id, string nome, string descricao, DateTime dataCriacao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            DataCriacao = dataCriacao;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
    }
}
