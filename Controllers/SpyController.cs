using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarkSpyduh.DataAccess;
using StarkSpyduh.Models;

namespace StarkSpyduh.Controllers
{
    [Route("api/Spies")]
    [ApiController]
    public class SpyController : Controller
    {
        SpyRepository _spyRepo = new SpyRepository();

        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _spyRepo.GetAll();
        }
        [HttpGet("{Id}")]
        public IActionResult GetSpyById(int id)
        {
            var match = _spyRepo.GetById(id);

            if (match == null)
            {
                return NotFound();
            }
            return Ok(match);
        }
        [HttpPost]
        public IActionResult AddNewSpy(Spy newSpy)
        {
            if (newSpy == null)
            {
                return NotFound();
            }
            else if (!ValidNewSpy(newSpy))
            {
                return BadRequest();
            }
            else
            {
                _spyRepo.Post(newSpy);
                return Ok(newSpy);
            }
        }
        private bool ValidNewSpy(Spy newSpy)
        {
            if (_spyRepo.GetById(newSpy.Id) != null)
            {
                return false;
            }
            if (newSpy.Name == null)
            {
                return false;
            }
            // Neet to Validate Friend and Enemy 
            if (newSpy.Friend != null)
            {

            }
            return true;
        }
    }
}
