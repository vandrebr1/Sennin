using Microsoft.AspNetCore.Mvc;
using Sennin.API.Interfaces;
using Sennin.API.Model;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sennin.API.Controllers
{

    [ApiController]
    [Route("v1/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IRepository<Usuario> repository;
        public UsuarioController([FromServices] IUnitOfWork unitOfWork, [FromServices] IRepository<Usuario> repository)
        {
            this.unitOfWork = unitOfWork;
            this.repository = repository;
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Usuario>> Get(int Id)
        {
            var model = await repository.SelectAsync(Id);

            if (model != null)
            {
                return Ok(model);
            }

            return NotFound();
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Usuario>>> Get()
        {
            var list = await repository.SelectAsync();
            return Ok(list);

        }

        [HttpPost("")]
        [SwaggerResponse(201, "Registro criado com sucesso")]
        [SwaggerResponse(400, "Campos inválidas")]
        public async Task<IActionResult> Post([FromBody] Usuario model)
        {
            model.PreenchePropriedadesNovoRegistro();
            unitOfWork.BeginTransaction();
            await repository.SaveAsync(model);
            unitOfWork.Commit();

            return CreatedAtAction(nameof(Post), new { model.Id }, model);

        }

        [HttpPut("")]
        [SwaggerResponse(201, "Registro atualizado com sucesso")]
        [SwaggerResponse(400, "Campos inválidas")]
        public async Task<IActionResult> Put([FromBody] Usuario model)
        {
            var modelExistente = await repository.SelectAsync(model.Id);

            if (modelExistente == null)
            {
                return NotFound();
            }
            else
            {
                model.PreenchePropriedadesAtualizaRegistro();
                unitOfWork.BeginTransaction();
                await repository.SaveAsync(model);
                unitOfWork.Commit();
                return NoContent();
            }

        }

        [HttpDelete("{Id:int}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var modelExistente = await repository.SelectAsync(Id);

            if (modelExistente == null)
            {
                return NotFound();
            }

            unitOfWork.BeginTransaction();
            await repository.DeleteAsync(Id);
            unitOfWork.Commit();
            return NoContent();
        }

    }
}
