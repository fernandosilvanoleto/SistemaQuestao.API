using Microsoft.EntityFrameworkCore;
using SistemaQuestao.Application.InputModels.Assunto;
using SistemaQuestao.Application.Services.Interfaces;
using SistemaQuestao.Application.ViewModels.Assunto;
using SistemaQuestao.Core.Entities;
using SistemaQuestao.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaQuestao.Application.Services.Repositories
{
    public class AssuntoService : IAssuntoInterface
    {
        private readonly SistemaQuestaoDbContext _dbContext;
        public AssuntoService(SistemaQuestaoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int CreateAssunto(CreateAssuntoInputModel inputModel)
        {
            try
            {
                var assunto = new Assunto(inputModel.Descricao, inputModel.Observacao, inputModel.IdDisciplina, inputModel.IdAssuntoPai);

                _dbContext.Assuntos.Add(assunto);
                _dbContext.SaveChanges();

                return assunto.Id;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public List<GetAssuntoAllViewModel> GetAllAssunto()
        {
            try
            {
                var assuntos = _dbContext.Assuntos;

                var getAssuntoAllViewModel = assuntos
                    .Include(d => d.Disciplina)
                    .Include(Asspai => Asspai.AssuntoPai)
                    .Select(a => new GetAssuntoAllViewModel(a.Descricao, a.Observacao, a.Status, a.Disciplina.Nome))
                    .ToList();

                return getAssuntoAllViewModel;
            }
            catch (Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public GetAssuntoByIdViewModel GetByIdAssunto(int id)
        {
            try
            {
                var assunto = _dbContext.Assuntos
                    .Include(d => d.Disciplina)
                    .Include(Asspai => Asspai.AssuntoPai)
                    .SingleOrDefault(a => a.Id == id);

                if (assunto == null)
                {
                    return null;
                }

                var getAssuntoByIdViewModel = new GetAssuntoByIdViewModel(
                        assunto.Descricao,
                        assunto.Observacao,
                        assunto.Status,
                        assunto.Disciplina.Nome,
                        assunto.AssuntoPai.Descricao
                    );

                return getAssuntoByIdViewModel;
            }
            catch (Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public void UpdateAdicionarAssuntoPai(UpdateAdicionarAssuntoPaiInputModel inputModel)
        {
            try
            {
                var assunto = _dbContext.Assuntos.SingleOrDefault(a => a.Id == inputModel.Id);

                assunto.AdicionarAssuntoPaiById(inputModel.IdAssuntoPai);
            }
            catch (Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public int UpdateAssunto(UpdateAssuntoInputModel inputModel)
        {
            try
            {
                var assunto = _dbContext.Assuntos.SingleOrDefault(a => a.Id == inputModel.Id);

                assunto.Update(inputModel.Descricao, inputModel.Observacao);

                return assunto.Id;                
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
