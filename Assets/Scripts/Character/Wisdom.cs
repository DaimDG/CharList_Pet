public class Wisdom : Skill
{
    public Wisdom (int value) : base(SkillType.Wisdom, value)
    {
        
    }
    private SkillProficiency _animalHandling = new SkillProficiency(ProficiencyType.AnimalHandling);
    private SkillProficiency _insight = new SkillProficiency(ProficiencyType.Insight);
    private SkillProficiency _medicine = new SkillProficiency(ProficiencyType.Medicine);
    private SkillProficiency _perception = new SkillProficiency(ProficiencyType.Perception);
    private SkillProficiency _survival = new SkillProficiency(ProficiencyType.Survival);
    
    
}