using Microsoft.AspNetCore.Mvc;
using SistemaQuestao.Application.InputModels.Area;
using SistemaQuestao.Application.Services.Interfaces;

namespace SistemaQuestao.API.Controllers
{
    [Route("sistemaquestao/areas")]
    public class AreaController : ControllerBase
    {
        private readonly IAreaInterface _areaInterface;
        public AreaController(IAreaInterface areaInterface)
        {
            _areaInterface = areaInterface;
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
    }
}
