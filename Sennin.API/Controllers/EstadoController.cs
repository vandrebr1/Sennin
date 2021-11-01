using Microsoft.AspNetCore.Mvc;
using Sennin.API.Infraestrutura.Interfaces;
using Sennin.API.Infraestrutura.Repository;
using Sennin.API.Model;
using System.Collections.Generic;

namespace Sennin.API.Controllers
{

    [ApiController]
    [Route("v1/[Controller]")]
    public class EstadoController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<Estado> _repository;
        public EstadoController([FromServices] IUnitOfWork unitOfWork, [FromServices] IRepository<Estado> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        [HttpGet("")]
        public IEnumerable<Estado> Get()
        {
            return _repository.Get();
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Estado model)
        {
            _unitOfWork.BeginTransaction();
            _repository.Save(model);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
