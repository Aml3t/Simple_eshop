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
            var _allPies = _pieRepository.AllPies;
            return Ok(_allPies);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!_pieRepository.AllPies.Any(p => p.PieId == id))
            {
                return NotFound();
            }
            return Ok(_pieRepository.AllPies.Where(p => p.PieId == id);
        }

    }
}
