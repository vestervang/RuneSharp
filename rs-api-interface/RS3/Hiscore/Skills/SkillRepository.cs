using System;
using System.Linq;

namespace RunescapeApi.RuneScape3.Hiscore.Skills
{
    public class SkillRepository
    {
        private readonly Skill[] _skills;

        public SkillRepository()
        {
            _skills = new Skill[]
            {
                new Total(),
                new Attack(),
                new Defence(),
                new Strength(),
                new Constitution(),
                new Ranged(),
                new Prayer(),
                new Magic(),
                new Cooking(),
                new Woodcutting(),
                new Fletching(),
                new Fishing(),
                new Firemaking(),
                new Crafting(),
                new Smithing(),
                new Mining(),
                new Herblore(),
                new Agility(),
                new Thieving(),
                new Slayer(),
                new Farming(),
                new Runecrafting(),
                new Hunter(),
                new Construction(),
                new Summoning(),
                new Dungeoneering(),
                new Divination(),
                new Invention()
            };
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