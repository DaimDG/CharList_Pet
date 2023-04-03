public class Dexterity : Skill
{
    public Dexterity(int value) : base(SkillType.Dexterity, value)
    {
        
    }
    private SkillProficiency _acrobatics = new SkillProficiency(ProficiencyType.Acrobatics);
    private SkillProficiency _sleightOfHand = new SkillProficiency(ProficiencyType.SleightOfHand);
    private SkillProficiency _stealth = new SkillProficiency(ProficiencyType.Stealth);
    public SkillProficiency Acrobatics
    {
        get => _acrobatics;
        set => _acrobatics = value;
    }
}