using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.ViewModels.Area
{
    public class GetAreaAllViewModel
    {
        public GetAreaAllViewModel(int id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
    }
}
