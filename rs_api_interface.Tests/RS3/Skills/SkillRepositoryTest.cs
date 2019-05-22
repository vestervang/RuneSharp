using rs_api_interface.RS3.Hiscore.Skills;
using Xunit;

namespace rs_api_interface.Tests.RS3
{
    public class SkillRepositoryTest
    {
        private readonly SkillRepository _repository;

        public SkillRepositoryTest()
        {
            _repository = new SkillRepository();
        }

        [Fact]
        public void TestGetUnknownSkill()
        {
            var skill = _repository.Skill(-1);
            Assert.Equal(null, skill);

            skill = _repository.Skill("something that doesn't exist");
            Assert.Equal(null, skill);
        }
        
        [Fact]
        public void TestGetTotalSkill()
        {
            var totalSkill = new Total();

            var skill = _repository.Skill(0);
            Assert.IsType(totalSkill.GetType(), skill);
            Assert.Equal("total", skill.Name);

            skill = _repository.Skill("total");
            Assert.IsType(totalSkill.GetType(), skill);
            Assert.Equal(0, skill.Id);
        }

        [Fact]
        public void TestGetAttackSkill()
        {
            var attackSkill = new Attack();

            var skill = _repository.Skill(1);
            Assert.IsType(attackSkill.GetType(), skill);
            Assert.Equal("attack", skill.Name);

            skill = _repository.Skill("attack");
            Assert.IsType(attackSkill.GetType(), skill);
            Assert.Equal(1, skill.Id);
        }

        [Fact]
        public void TestGetDefenceSkill()
        {
            var defenceSkill = new Defence();

            var skill = _repository.Skill(2);
            Assert.IsType(defenceSkill.GetType(), skill);
            Assert.Equal("defence", skill.Name);

            skill = _repository.Skill("defence");
            Assert.IsType(defenceSkill.GetType(), skill);
            Assert.Equal(2, skill.Id);
        }

        [Fact]
        public void TestGetStrengthSkill()
        {
            var strengthSkill = new Strength();

            var skill = _repository.Skill(3);
            Assert.IsType(strengthSkill.GetType(), skill);
            Assert.Equal("strength", skill.Name);

            skill = _repository.Skill("strength");
            Assert.IsType(strengthSkill.GetType(), skill);
            Assert.Equal(3, skill.Id);
        }

        [Fact]
        public void TestGetConstitutionSkill()
        {
            var constitutionSkill = new Constitution();

            var skill = _repository.Skill(4);
            Assert.IsType(constitutionSkill.GetType(), skill);
            Assert.Equal("constitution", skill.Name);

            skill = _repository.Skill("constitution");
            Assert.IsType(constitutionSkill.GetType(), skill);
            Assert.Equal(4, skill.Id);
        }

        [Fact]
        public void TestGetRangedSkill()
        {
            var rangedSkill = new Ranged();

            var skill = _repository.Skill(5);
            Assert.IsType(rangedSkill.GetType(), skill);
            Assert.Equal("ranged", skill.Name);

            skill = _repository.Skill("ranged");
            Assert.IsType(rangedSkill.GetType(), skill);
            Assert.Equal(5, skill.Id);
        }

        [Fact]
        public void TestGetPrayerSkill()
        {
            var prayerSkill = new Prayer();

            var skill = _repository.Skill(6);
            Assert.IsType(prayerSkill.GetType(), skill);
            Assert.Equal("prayer", skill.Name);

            skill = _repository.Skill("prayer");
            Assert.IsType(prayerSkill.GetType(), skill);
            Assert.Equal(6, skill.Id);
        }

        [Fact]
        public void TestGetMagicSkill()
        {
            var magicSkill = new Magic();

            var skill = _repository.Skill(7);
            Assert.IsType(magicSkill.GetType(), skill);
            Assert.Equal("magic", skill.Name);

            skill = _repository.Skill("magic");
            Assert.IsType(magicSkill.GetType(), skill);
            Assert.Equal(7, skill.Id);
        }

        [Fact]
        public void TestGetCookingSkill()
        {
            var cookingSkill = new Cooking();

            var skill = _repository.Skill(8);
            Assert.IsType(cookingSkill.GetType(), skill);
            Assert.Equal("cooking", skill.Name);

            skill = _repository.Skill("cooking");
            Assert.IsType(cookingSkill.GetType(), skill);
            Assert.Equal(8, skill.Id);
        }

        [Fact]
        public void TestGetWoodcuttingSkill()
        {
            var woodcuttingSkill = new Woodcutting();

            var skill = _repository.Skill(9);
            Assert.IsType(woodcuttingSkill.GetType(), skill);
            Assert.Equal("woodcutting", skill.Name);

            skill = _repository.Skill("woodcutting");
            Assert.IsType(woodcuttingSkill.GetType(), skill);
            Assert.Equal(9, skill.Id);
        }

        [Fact]
        public void TestGetFletchingSkill()
        {
            var fletchingSkill = new Fletching();

            var skill = _repository.Skill(10);
            Assert.IsType(fletchingSkill.GetType(), skill);
            Assert.Equal("fletching", skill.Name);

            skill = _repository.Skill("fletching");
            Assert.IsType(fletchingSkill.GetType(), skill);
            Assert.Equal(10, skill.Id);
        }

        [Fact]
        public void TestGetFishingSkill()
        {
            var fishingSkill = new Fishing();

            var skill = _repository.Skill(11);
            Assert.IsType(fishingSkill.GetType(), skill);
            Assert.Equal("fishing", skill.Name);

            skill = _repository.Skill("fishing");
            Assert.IsType(fishingSkill.GetType(), skill);
            Assert.Equal(11, skill.Id);
        }

        [Fact]
        public void TestGetFiremakingSkill()
        {
            var firemakingSkill = new Firemaking();

            var skill = _repository.Skill(12);
            Assert.IsType(firemakingSkill.GetType(), skill);
            Assert.Equal("firemaking", skill.Name);

            skill = _repository.Skill("firemaking");
            Assert.IsType(firemakingSkill.GetType(), skill);
            Assert.Equal(12, skill.Id);
        }

        [Fact]
        public void TestGetCraftingSkill()
        {
            var craftingSkill = new Crafting();

            var skill = _repository.Skill(13);
            Assert.IsType(craftingSkill.GetType(), skill);
            Assert.Equal("crafting", skill.Name);

            skill = _repository.Skill("crafting");
            Assert.IsType(craftingSkill.GetType(), skill);
            Assert.Equal(13, skill.Id);
        }

        [Fact]
        public void TestGetSmithingSkill()
        {
            var smithingSkill = new Smithing();

            var skill = _repository.Skill(14);
            Assert.IsType(smithingSkill.GetType(), skill);
            Assert.Equal("smithing", skill.Name);

            skill = _repository.Skill("smithing");
            Assert.IsType(smithingSkill.GetType(), skill);
            Assert.Equal(14, skill.Id);
        }

        [Fact]
        public void TestGetMiningSkill()
        {
            var miningSkill = new Mining();

            var skill = _repository.Skill(15);
            Assert.IsType(miningSkill.GetType(), skill);
            Assert.Equal("mining", skill.Name);

            skill = _repository.Skill("mining");
            Assert.IsType(miningSkill.GetType(), skill);
            Assert.Equal(15, skill.Id);
        }

        [Fact]
        public void TestGetHerbloreSkill()
        {
            var herbloreSkill = new Herblore();

            var skill = _repository.Skill(16);
            Assert.IsType(herbloreSkill.GetType(), skill);
            Assert.Equal("herblore", skill.Name);

            skill = _repository.Skill("herblore");
            Assert.IsType(herbloreSkill.GetType(), skill);
            Assert.Equal(16, skill.Id);
        }

        [Fact]
        public void TestGetAgilitySkill()
        {
            var agilitySkill = new Agility();

            var skill = _repository.Skill(17);
            Assert.IsType(agilitySkill.GetType(), skill);
            Assert.Equal("agility", skill.Name);

            skill = _repository.Skill("agility");
            Assert.IsType(agilitySkill.GetType(), skill);
            Assert.Equal(17, skill.Id);
        }

        [Fact]
        public void TestGetThievingSkill()
        {
            var thievingSkill = new Thieving();

            var skill = _repository.Skill(18);
            Assert.IsType(thievingSkill.GetType(), skill);
            Assert.Equal("thieving", skill.Name);

            skill = _repository.Skill("thieving");
            Assert.IsType(thievingSkill.GetType(), skill);
            Assert.Equal(18, skill.Id);
        }

        [Fact]
        public void TestGetSlayerSkill()
        {
            var slayerSkill = new Slayer();

            var skill = _repository.Skill(19);
            Assert.IsType(slayerSkill.GetType(), skill);
            Assert.Equal("slayer", skill.Name);

            skill = _repository.Skill("slayer");
            Assert.IsType(slayerSkill .GetType(), skill);
            Assert.Equal(19, skill.Id);
        }
        
        [Fact]
        public void TestGetFarmingSkill()
        {
            var farmingSkill = new Farming();

            var skill = _repository.Skill(20);
            Assert.IsType(farmingSkill.GetType(), skill);
            Assert.Equal("farming", skill.Name);

            skill = _repository.Skill("farming");
            Assert.IsType(farmingSkill .GetType(), skill);
            Assert.Equal(20, skill.Id);
        }
        
        [Fact]
        public void TestGetRunecraftingSkill()
        {
            var runecraftingSkill = new Runecrafting();

            var skill = _repository.Skill(21);
            Assert.IsType(runecraftingSkill.GetType(), skill);
            Assert.Equal("runecrafting", skill.Name);

            skill = _repository.Skill("runecrafting");
            Assert.IsType(runecraftingSkill .GetType(), skill);
            Assert.Equal(21, skill.Id);
        }
        
        [Fact]
        public void TestGetHunterSkill()
        {
            var hunterSkill = new Hunter();

            var skill = _repository.Skill(22);
            Assert.IsType(hunterSkill.GetType(), skill);
            Assert.Equal("hunter", skill.Name);

            skill = _repository.Skill("hunter");
            Assert.IsType(hunterSkill .GetType(), skill);
            Assert.Equal(22, skill.Id);
        }
        
        [Fact]
        public void TestGetConstructionSkill()
        {
            var constructionSkill = new Construction();

            var skill = _repository.Skill(23);
            Assert.IsType(constructionSkill.GetType(), skill);
            Assert.Equal("construction", skill.Name);

            skill = _repository.Skill("construction");
            Assert.IsType(constructionSkill .GetType(), skill);
            Assert.Equal(23, skill.Id);
        }
        
        [Fact]
        public void TestGetSummoningSkill()
        {
            var summoningSkill = new Summoning();

            var skill = _repository.Skill(24);
            Assert.IsType(summoningSkill.GetType(), skill);
            Assert.Equal("summoning", skill.Name);

            skill = _repository.Skill("summoning");
            Assert.IsType(summoningSkill .GetType(), skill);
            Assert.Equal(24, skill.Id);
        }
        
        [Fact]
        public void TestGetDungeoneeringSkill()
        {
            var dungeoneeringSkill = new Dungeoneering();

            var skill = _repository.Skill(25);
            Assert.IsType(dungeoneeringSkill.GetType(), skill);
            Assert.Equal("dungeoneering", skill.Name);

            skill = _repository.Skill("dungeoneering");
            Assert.IsType(dungeoneeringSkill .GetType(), skill);
            Assert.Equal(25, skill.Id);
        }
        
        [Fact]
        public void TestGetDivinationSkill()
        {
            var divinationSkill = new Divination();

            var skill = _repository.Skill(26);
            Assert.IsType(divinationSkill.GetType(), skill);
            Assert.Equal("divination", skill.Name);

            skill = _repository.Skill("divination");
            Assert.IsType(divinationSkill .GetType(), skill);
            Assert.Equal(26, skill.Id);
        }
        
        [Fact]
        public void TestGetInventionSkill()
        {
            var inventionSkill = new Invention();

            var skill = _repository.Skill(27);
            Assert.IsType(inventionSkill.GetType(), skill);
            Assert.Equal("invention", skill.Name);

            skill = _repository.Skill("invention");
            Assert.IsType(inventionSkill .GetType(), skill);
            Assert.Equal(27, skill.Id);
        }

        [Fact]
        public void TestSkillCount()
        {
            var skillCount = _repository.Length();            
            Assert.Equal(28, skillCount);
        }
    }
}