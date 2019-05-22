namespace RuneSharp.Core.Hiscore.Skill
{
    public abstract class Skill : ISkill
    {
        public virtual int Id { get; protected set; }

        public virtual string Name { get; protected set; }
        public virtual long MaximumExperience { get; protected set; }
        public virtual int MaximumLevel { get; protected set; }
        public virtual bool IsCombat { get; protected set; }
        public virtual bool IsMembers { get; protected set; }
    }
}