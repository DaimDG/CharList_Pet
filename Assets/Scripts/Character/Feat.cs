using UnityEngine;
[CreateAssetMenu(fileName = "Feat", menuName = "ScriptableObjects/Feat", order = 1)]
public class Feat : ScriptableObject
{
    private string _name;
    private string _description;
    private RaceSkill[] _skillParameters;
    private RaceProficiency[] _proficiencyParameters;
}
