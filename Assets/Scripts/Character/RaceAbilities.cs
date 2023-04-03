using UnityEngine;

[System.Serializable]
public class RaceVision
{
    [SerializeField] private Vision _visionType;
    [SerializeField] private int _visionDistance;

    public RaceVision(Vision visionType, int visionDistance)
     {
         _visionType = visionType;
         _visionDistance = visionDistance;
     }
}

[System.Serializable]
public class RaceProficiency
{
    [SerializeField] private SkillProficiency _proficiency;
    [SerializeField] private int _profiencyValue;

    public RaceProficiency(SkillProficiency proficiency, int profiencyValue)
    {
        _proficiency = proficiency;
        _profiencyValue = profiencyValue;
    }
}

[System.Serializable]
public class RaceSkill
{
    [SerializeField] private SkillType _skill;
    [SerializeField] private int _skillValue;

    public RaceSkill(SkillType skill, int skillValue)
    {
        _skill = skill;
        _skillValue = skillValue;
    }
}