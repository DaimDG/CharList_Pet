public class Strength : Skill
{
    public Strength (int value) : base(SkillType.Strength, value)
    {
       
    }
    private SkillProficiency _athletics = new SkillProficiency(ProficiencyType.Athletics);
    public SkillProficiency Athletics
    {
        get => _athletics;
        set => _athletics = value;
    }
}