using System;
using System.Collections.Generic;
using System.Linq;
using RuneSharp.RS3.Hiscore.Skills;

namespace RunescapeApi.RuneScape3.Hiscore.Stats
{
    public class StatsRepository
    {
        private List<Stat> _stats;
        private SkillRepository _skillRepository;

        public StatsRepository(string apiFeed)
        {
            _skillRepository = new SkillRepository();
            _stats = makeStatsList(apiFeed);
        }

        private static string[] convertFeedToArray(string feed)
        {
            return feed.Split(
                new[] {"\r\n", "\r", "\n"},
                StringSplitOptions.None
            );
        }

        private static Stat convertFeedLineToStat(Skill skill, string feedLine)
        {
            var feedLineSplit = feedLine.Split(",");

            var rank = int.Parse(feedLineSplit[0]);
            var level = int.Parse(feedLineSplit[1]);
            var xp = long.Parse(feedLineSplit[2]);

            return new Stat(skill, rank, level, xp);
        }

        private List<Stat> makeStatsList(string feed)
        {
            var rawStats = convertFeedToArray(feed);

            var stats = new List<Stat>();

            for (var i = 0; i < _skillRepository.Length(); i++)
            {
                var statLine = rawStats[i];
                var currentSkill = _skillRepository.Skill(i);

                var stat = convertFeedLineToStat(currentSkill, statLine);

                stats.Add(stat);
            }

            return stats;
        }

        public Stat Stat(string skillName)
        {
            return _stats.FirstOrDefault(
                stat => string.CompareOrdinal(stat.Activity.Name, skillName.ToLower()) == 0
            );
        }

        public Stat Stat(int skillId)
        {
            return _stats.FirstOrDefault(stat => stat.Activity.Id == skillId);
        }
    }
}