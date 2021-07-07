using Microsoft.AspNetCore.Mvc;
using SistemaQuestao.Application.InputModels.Assunto;
using SistemaQuestao.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaQuestao.API.Controllers
{
    [Route("sistemaquestao/assunto")]
    public class AssuntoController : ControllerBase
    {
        private readonly IAssuntoInterface _assuntoInterface;
        public AssuntoController(IAssuntoInterface assuntoInterface)
        {
            _assuntoInterface = assuntoInterface;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var assuntos = _assuntoInterface.GetAllAssunto();
                if (assuntos == null)
                {
                    return NoContent();
                }

                return Ok(assuntos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdAssunto(int id)
        {
            try
            {
                var assunto = _assuntoInterface.GetByIdAssunto(id);

                if (assunto == null)
                {
                    return Ok("Nenhum registro encontrado!");
                }

                return Ok(assunto);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateAssuntoInputModel inputModel)
        {
            try
            {
                var idAssunto = _assuntoInterface.CreateAssunto(inputModel);

                if (idAssunto == 0)
                {
                    return Ok("Registro não foi salvo no banco de dados!");
                }

                return CreatedAtAction(nameof(GetByIdAssunto), new { id = inputModel }, inputModel);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        [HttpPut]
        [Route("adicionar-assunto-pai/{id:int}")]
        public IActionResult AdicionarAssuntoPai(int id, [FromBody] UpdateAdicionarAssuntoPaiInputModel inputModel)
        {
            try
            {
                var idAssuntoPai = _assuntoInterface.UpdateAdicionarAssuntoPai(inputModel);

                if (idAssuntoPai == 0)
                {
                    return Ok("Vínculo de assunto pai com o assunto em questão não realizado com sucesso no banco de dados!");
                }

                return CreatedAtAction(nameof(GetByIdAssunto), new { id = idAssuntoPai }, inputModel);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        [HttpPut]
        [Route("atualizar-assunto/{id:int}")]
        public IActionResult AtualizarAssunto(int id, [FromBody] UpdateAssuntoInputModel inputModel)
        {
            try
            {
                var idAssunto = _assuntoInterface.UpdateAssunto(inputModel);

                if (idAssunto == 0)
                {
                    return Ok("Assunto não atualizado com sucesso!");
                }

                return CreatedAtAction(nameof(GetByIdAssunto), new { id = idAssunto }, inputModel);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
