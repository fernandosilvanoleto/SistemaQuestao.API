using Microsoft.AspNetCore.Mvc;
using SistemaQuestao.Application.InputModels.Area;
using SistemaQuestao.Application.Services.Interfaces;

namespace SistemaQuestao.API.Controllers
{
    [Route("sistemaquestao/areas")]
    public class AreaController : ControllerBase
    {
        private readonly IAreaInterface _areaInterface;
        private readonly IAreaDisciplinaInterface _areaDisciplinaInterface;
        public AreaController(IAreaInterface areaInterface, IAreaDisciplinaInterface areaDisciplinaInterface)
        {
            _areaInterface = areaInterface;
            _areaDisciplinaInterface = areaDisciplinaInterface;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var areas = _areaInterface.GetAllArea();

            if (areas == null)
            {
                return NotFound();
            }

            return Ok(areas);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var area = _areaInterface.GetByIdArea(id);

            if (area == null)
            {
                return NotFound();
            }

            return Ok(area);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateAreaInputModel inputModel)
        {
            var id = _areaInterface.CreateArea(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateAreaInputModel inputModel)
        {
            _areaInterface.UpdateArea(inputModel);

            return Ok();
        }

        [HttpGet]
        [Route("getdisciplinaporarea/{id:int}")]
        public IActionResult GetDisciplinasPorAreaEspecific(int id)
        {
            var areadisciplina = _areaDisciplinaInterface.GetDisciplinasPorAreaEspecific(id);

            if (areadisciplina == null)
            {
                return Ok("Area não tem disciplinas vinculadas. Por favor, confere novamente os dados!");
            }

            return Ok(areadisciplina);
        }
    }
}
