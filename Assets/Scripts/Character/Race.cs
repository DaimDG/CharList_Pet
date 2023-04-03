using UnityEngine;
using UnityEngine.Serialization;

public abstract class Race : ScriptableObject
{
    public Sprite[] avatars;
    public virtual RaceType _RaceType { get; }
    [SerializeField] private float ageMin;
    [SerializeField] private float ageMax;
    [SerializeField] private float growthMin;
    [SerializeField] private float growthMax;
    [SerializeField] private float weightMin;
    [SerializeField] private float weightMax;
    [SerializeField] private float speedRun;
    [SerializeField] private float speedFlying;
    [SerializeField] private float speedSwimming;
    [SerializeField] private float speedClimbing;
    [SerializeField] private Gradient colorsOfSkin;
    [SerializeField] private Gradient colorsOfHairs;
    [SerializeField] private Gradient colorsOfEyes;
    public float _RaceSize => GetRaceSize();
    public virtual RaceSize RaceSizeType { get; }
    [SerializeField] private RaceVision[] _visions;
    [SerializeField] private SkillProficiency[] _proficiencies;
    [SerializeField] private RaceSkill[] _skills;
    [SerializeField] private Language[] _languages;
    [SerializeField] private DamageType[] _damageResistances;
    private float GetRaceSize()
    {
        float raceSize = 0;
        switch (RaceSizeType)
        {
            case RaceSize.Tiny: raceSize = 2.5f; break;
            case RaceSize.Small: raceSize = 5f; break;
            case RaceSize.Medium: raceSize = 5f; break;
            case RaceSize.Large: raceSize = 10f; break;
            case RaceSize.Huge: raceSize = 15f; break;
            case RaceSize.Gargantuan: raceSize = 20f; break;
            default: raceSize = 0; break;
        }
        return raceSize;
    }
}

