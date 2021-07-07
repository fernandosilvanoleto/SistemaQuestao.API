using SistemaQuestao.Application.InputModels.Assunto;
using SistemaQuestao.Application.ViewModels.Assunto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.Services.Interfaces
{
    public interface IAssuntoInterface
    {
        List<GetAssuntoAllViewModel> GetAllAssunto();
        GetAssuntoByIdViewModel GetByIdAssunto(int id);
        int CreateAssunto(CreateAssuntoInputModel inputModel);
        int UpdateAssunto(UpdateAssuntoInputModel inputModel);
        int UpdateAdicionarAssuntoPai(UpdateAdicionarAssuntoPaiInputModel inputModel);
    }
}
