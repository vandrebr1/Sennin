using Microsoft.AspNetCore.Mvc;
using Sennin.API.Infraestrutura.Interfaces;
using Sennin.API.Infraestrutura.Repository;
using Sennin.API.Model;
using System.Collections.Generic;

namespace Sennin.API.Controllers
{

    [ApiController]
    [Route("v1/[Controller]")]
    public class PaisController : ControllerBase
    {
        private IUnitOfWork _unitOfWork;
        private IRepository<Pais> _repository;
        public PaisController([FromServices] IUnitOfWork unitOfWork, [FromServices] IRepository<Pais> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        [HttpGet("")]
        public IEnumerable<Pais> Get()
        {
            return _repository.Get();
        }

        [HttpPost("")]
        public IActionResult Post([FromBody] Pais pais)
        {
            _unitOfWork.BeginTransaction();
            _repository.Save(pais);
            _unitOfWork.Commit();
            return Ok();
        }
    }
}
