using System.Collections.Generic;
using System.Linq;
using System;
using RuneSharp.Core.Hiscore.Skill;
// Make static functions callable
using staticStat = RuneSharp.Core.Hiscore.Stat.Stat;

namespace RuneSharp.Core.Hiscore.Stat
{
    public abstract class StatRepository : IStatRepository
    {
        private List<Stat> _stats;
        private ISkillRepository _skillRepository;

        protected StatRepository(string apiFeed, ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
            _stats = MakeStatsList(apiFeed);
        }

        private static string[] ConvertFeedToStatLines(string feed)
        {
            return feed.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
        }

        private List<Stat> MakeStatsList(string feed)
        {
            var statLines = ConvertFeedToStatLines(feed);

            var stats = new List<Stat>();

            for (var i = 0; i < _skillRepository.Length(); i++)
            {
                var statLine = statLines[i];
                var currentSkill = _skillRepository.Skill(i);
                
                Hiscore.Stat.Stat.TryParseData(statLine, currentSkill, out var stat);
                
                stats.Add(stat);
            }

            return stats;
        }

        public Stat Stat(string skillName)
        {
            return _stats.FirstOrDefault(
                stat => string.CompareOrdinal(stat.Skill.Name, skillName.ToLower()) == 0
            );
        }

        public Stat Stat(int skillId)
        {
            return _stats.FirstOrDefault(stat => stat.Skill.Id == skillId);
        }

        public List<Stat> Stats
        {
            get { return _stats; }
        }
    }
}