public class Charisma : Skill
{   
    public Charisma (int value) : base(SkillType.Charisma, value)
    {
       
    }
    private SkillProficiency _deception = new SkillProficiency(ProficiencyType.Deception);
    private SkillProficiency _intimidation = new SkillProficiency(ProficiencyType.Intimidation);
    private SkillProficiency _performance = new SkillProficiency(ProficiencyType.Performance);
    private SkillProficiency _persuasion = new SkillProficiency(ProficiencyType.Persuasion);
    private SkillProficiency _survival = new SkillProficiency(ProficiencyType.Survival);
}