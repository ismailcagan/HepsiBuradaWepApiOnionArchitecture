using HepsiBurada.Application.Interface.UnitOfWorks;
using HepsiBurada.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HepsiBuradaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _unitOfWork.GetReadRepository<Product>().GetAllAsync());
        }
    }
}
