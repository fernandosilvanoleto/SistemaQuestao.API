using Microsoft.AspNetCore.Mvc;
using SistemaQuestao.Application.InputModels.AreaDisciplina;
using SistemaQuestao.Application.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaQuestao.API.Controllers
{
    [Route("sistemaquestao/areadisciplina")]
    public class AreaDisciplinaController : ControllerBase
    {
        private readonly IAreaDisciplinaInterface _areaDisciplinaInterface;
        public AreaDisciplinaController(IAreaDisciplinaInterface areaDisciplinaInterface)
        {
            _areaDisciplinaInterface = areaDisciplinaInterface;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var areaDisciplinas = _areaDisciplinaInterface.GetAllAreaDisciplina();

                if (areaDisciplinas == null)
                {
                    return NotFound();
                }

                return Ok(areaDisciplinas);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var area_disciplina = _areaDisciplinaInterface.GetByIdAreaDisciplina(id);

                if (area_disciplina == null)
                    return null;

                return Ok(area_disciplina);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateAreaDisciplinaInputModel inputModel)
        {
            try
            {
                var id = _areaDisciplinaInterface.CreateDisciplina(inputModel);

                return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var area_disciplina = _areaDisciplinaInterface.DeleteAreaDisciplinaModel(id);

                if (area_disciplina == null)
                {
                    return Ok("Area Disciplina não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
                }

                return Ok("Area Disciplina removido com sucesso!!!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut("active/{id}")]
        public IActionResult ActiveAreaDisciplina(int id)
        {
            try
            {
                var area_disciplina = _areaDisciplinaInterface.ActiveAreaDisciplinaModel(id);

                if (area_disciplina == null)
                {
                    return Ok("Area Disciplina não encontrado em nosso banco de dados. Por favor, confere novamente os dados!");
                }

                return Ok("Area Disciplina adicionada com sucesso!!!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
