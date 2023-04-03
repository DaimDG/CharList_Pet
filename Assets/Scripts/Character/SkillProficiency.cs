using UnityEngine;

public class SkillProficiency
{
    public SkillProficiency(ProficiencyType proficiencyType) 
    { 
        ProfType = proficiencyType; 
    }
    private int _skillProficiencyValue;
    private int _proficiencyLevel;
    private ProficiencyType _proficiencyType;
    public int Value
    { 
        get => _skillProficiencyValue;
        set => _skillProficiencyValue = Mathf.Clamp(value, 0, 20);
    }
    private ProficiencyType ProfType { get; set; }
    public int ProficiencyLevel
    {
        get => _proficiencyLevel;
        set => _proficiencyLevel = Mathf.Clamp(value, 0, 2);
    }
}
