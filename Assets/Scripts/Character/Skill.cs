using System;

public abstract class Skill
{
    private SkillType _skillType;
    public SkillProficiency _savingThrow = new SkillProficiency(ProficiencyType.SavingThrow);
    private int _skillValue;
    private int _skillModificator;

    private int Value
    {
        get => _skillValue;
        set 
        { 
            _skillValue = Math.Clamp(value, 0, 100);
            SetModificator();
        }
    }
    
    protected Skill(SkillType skillType, int skillValue)
    {
        this._skillType = skillType;
        Value = skillValue;        
    }

    public int SetSkillValue(int value)
	{
        this._skillValue = Math.Clamp(value, 0, 100);
		SetModificator();
        return this._skillValue;
    }

    protected void SetSkillType(SkillType type)
    {
        this._skillType = type;
    }

    public int Modificator
    {
        get { return _skillModificator;}       
    }

    protected int SavingThrow
    {
        get { return _savingThrow.Value; }
        set { _savingThrow.Value = value; }
    }

    protected void SetModificator()
    {
        _skillModificator = (int)MathF.Floor((_skillValue - 10) / 2f);
    }

    public SkillType GetSkillType()
    {
        return _skillType;
	}
}


