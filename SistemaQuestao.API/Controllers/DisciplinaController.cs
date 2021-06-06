using Microsoft.AspNetCore.Mvc;
using SistemaQuestao.Application.InputModels.Disciplina;
using SistemaQuestao.Application.Services.Interfaces;
using System;

namespace SistemaQuestao.API.Controllers
{
    [Route("sistemaquestao/disciplinas")]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaInterface _disciplinaInterface;
        public DisciplinaController(IDisciplinaInterface disciplinaInterface)
        {
            _disciplinaInterface = disciplinaInterface;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var disciplinas = _disciplinaInterface.GetAllDisciplina();

                if (disciplinas == null)
                    return NotFound();

                return Ok(disciplinas);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdDisciplina(int id)
        {
            try
            {
                var disciplina = _disciplinaInterface.GetByIdDisciplina(id);

                if (disciplina == null)
                {
                    return NoContent();
                }

                return Ok(disciplina);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateDisciplinaInputModel inputModel)
        {
            try
            {
                var idDisciplina = _disciplinaInterface.CreateDisciplina(inputModel);

                if (idDisciplina == null)
                {
                    return NoContent();
                }

                return Ok("Cadastro feito com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateDisciplinaInputModel inputModel)
        {
            try
            {
                _disciplinaInterface.UpdateDisciplina(inputModel);

                return Ok("Alteração realizada com sucesso!!!");
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
