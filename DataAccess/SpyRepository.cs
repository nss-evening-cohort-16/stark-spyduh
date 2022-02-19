
using StarkSpyduh.Models;

namespace StarkSpyduh.DataAccess
{
    public class SpyRepository
    {
        private static List<Spy> _Spies = new List<Spy>()
        {
        new Spy()
        {
            Name = "JamesBond",
            Id = 1,
            Friend = true,
            Enemy = false,
            Skill = SkillsType.Poison
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
        internal object? GetById(int id)
        {
            var match = _Spies.FirstOrDefault(s => s.Id == id);
            if (match == null) return null;
            return match;
        }


        internal void Post(Spy newSpy)
        {
            _Spies.Add(newSpy);
        }
        internal List<Spy> GetAll()
        {
            return _Spies;
        }

        internal IEnumerable<Spy> GetSkills(SkillsType skillType)
        {
            var spySkills = _Spies.Where(s => s.Skill == skillType);
            return spySkills;
        }
    }
}
