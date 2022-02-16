using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarkSpyduh.Models;

namespace StarkSpyduh.Controllers
{
    [Route("api/spy")]
    [ApiController]
    public class SpyController : Controller
    {
        private static List<Spy> _Spies = new List<Spy>()
        {
        new Spy()
        {
            Name = "JmaesBond",
            Id = 1,
            Friend = true,
            Enemy = false,
            Skill = SkillsType.None
        },
        new Spy()
        {
            Name = "Casper",
            Id = 2,
            Friend = false,
            Enemy = true,
            Skill = SkillsType.Hacking
        },
        new Spy(){
            Name = "Basil",
            Id = 3,
            Friend = true,
            Enemy = false,
            Skill = SkillsType.MoneyLoundering
        },
        new Spy()
        {
            Name = "Hunter",
            Id = 4,
            Friend = false,
            Enemy = true,
            Skill = SkillsType.Wiretapping
        },
        new Spy()
        {
            Name = "Moonlight",
            Id = 5,
            Friend = false,
            Enemy= true,
            Skill = SkillsType.Whistleblower
        },
        };
        [HttpGet]
        public List<Spy> GetAllSpies()
        {
            return _Spies;
        }
        [HttpPost]
        public IActionResult AddNewSpy(Spy newSpy)
        {
            _Spies.Add(newSpy);

            return Ok(newSpy);
        }
    }
}
