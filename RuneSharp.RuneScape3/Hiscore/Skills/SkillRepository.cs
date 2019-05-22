using RuneSharp.Core.Hiscore.Skill;

namespace RuneSharp.RuneScape3.Hiscore.Skills
{
    public class SkillRepository : RuneSharp.Core.Hiscore.Skill.SkillRepository
    {
        public SkillRepository() : base(
            new Skill[]
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
            }
        )
        {
        }
    }
}