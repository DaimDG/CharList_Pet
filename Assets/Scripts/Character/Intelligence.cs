public class Intelligence : Skill
{   
    public Intelligence (int value) : base(SkillType.Intelligence, value)
    {
       
    }
    private SkillProficiency _arcana = new SkillProficiency(ProficiencyType.Arcana);
    private SkillProficiency _history = new SkillProficiency(ProficiencyType.History);
    private SkillProficiency _investigation = new SkillProficiency(ProficiencyType.Investigation);
    private SkillProficiency _nature = new SkillProficiency(ProficiencyType.Nature);
    private SkillProficiency _religion = new SkillProficiency(ProficiencyType.Religion);
}