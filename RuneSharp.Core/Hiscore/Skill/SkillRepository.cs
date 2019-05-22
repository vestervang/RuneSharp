using System;
using System.Linq;

namespace RuneSharp.Core.Hiscore.Skill
{
    public abstract class SkillRepository : ISkillRepository
    {
        private readonly Skill[] _skills;

        public SkillRepository(Skill[] skills)
        {
            _skills = skills;
        }
        
        public Skill Skill(string skillName)
        {
            return _skills.FirstOrDefault(
                skill => string.CompareOrdinal(skill.Name, skillName.ToLower()) == 0
            );
        }

        public Skill Skill(int skillId)
        {
            return _skills.FirstOrDefault(skill => skill.Id == skillId);
        }

        public Skill Skill<T>(T identifier)
        {
            throw new NotImplementedException("Not implemented");
        }

        public int Length()
        {
            return _skills.Length;
        }
    }
}