using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.ViewModels.Disciplina
{
    public class GetDisciplinaAllViewModel
    {
        public GetDisciplinaAllViewModel(int id, string nome, string? complemento)
        {
            Id = id;
            Nome = nome;
            Complemento = complemento;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string? Complemento { get; private set; }
    }
}
