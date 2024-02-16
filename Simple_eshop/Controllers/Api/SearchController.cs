using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Simple_Eshop.Models;

namespace Simple_Eshop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPieRepository _pieRepository;

        public SearchController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _pieRepository.AllPies.ToList();
            return (items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            
        }
        
    }
}
