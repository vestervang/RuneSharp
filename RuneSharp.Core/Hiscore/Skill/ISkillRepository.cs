namespace RuneSharp.Core.Hiscore.Skill
{
    public interface ISkillRepository
    {
        Skill Skill(string skillName);

        Skill Skill(int skillId);

        Skill Skill<T>(T identifier);

        int Length();
    }
}