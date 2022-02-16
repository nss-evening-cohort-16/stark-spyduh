namespace StarkSpyduh.Models
{
    public class Spy
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public bool Friend { get; set; }

        public bool Enemy { get; set; }

        public SkillsType Skill { get; set; }

    }
    public enum SkillsType
    {
        None, 
        Wiretapping, 
        Hacking, 
        MoneyLoundering, 
        Whistleblower,
    }
}
