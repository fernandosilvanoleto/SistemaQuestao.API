using SistemaQuestao.Application.InputModels.Disciplina;
using SistemaQuestao.Application.Services.Interfaces;
using SistemaQuestao.Application.ViewModels.Disciplina;
using SistemaQuestao.Core.Entities;
using SistemaQuestao.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaQuestao.Application.Services.Repositories
{
    public class DisciplinaService : IDisciplinaInterface
    {
        private readonly SistemaQuestaoDbContext _dbContext;
        public DisciplinaService(SistemaQuestaoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateDisciplina(CreateDisciplinaInputModel inputModel)
        {
            try
            {
                var disciplina = new Disciplina(inputModel.Nome, inputModel.Complemento);

                _dbContext.Disciplinas.Add(disciplina);
                _dbContext.SaveChanges();

                return disciplina.Id;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public List<GetDisciplinaAllViewModel> GetAllDisciplina()
        {
            try
            {
                var disciplinas = _dbContext.Disciplinas;

                var GetDisciplinaAllViewModel = disciplinas
                .Select(d => new GetDisciplinaAllViewModel(d.Id, d.Nome, d.Complemento))
                .ToList();

                return GetDisciplinaAllViewModel;
            }
            catch (Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public GetDisciplinaByIdViewModel GetByIdDisciplina(int id)
        {
            try
            {
                var disciplina = _dbContext.Disciplinas.SingleOrDefault(d => d.Id == id);

                if (disciplina == null)
                    return null;

                var getDisciplinaByIdViewModel = new GetDisciplinaByIdViewModel(
                        disciplina.Id,
                        disciplina.Nome,
                        disciplina.Complemento,
                        disciplina.DataCriacao
                    );

                return getDisciplinaByIdViewModel;
            }
            catch (Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public void UpdateDisciplina(UpdateDisciplinaInputModel inputModel)
        {
            try
            {
                var disciplina = _dbContext.Disciplinas.SingleOrDefault(d => d.Id == inputModel.Id);

                disciplina.Update(inputModel.Complemento);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
