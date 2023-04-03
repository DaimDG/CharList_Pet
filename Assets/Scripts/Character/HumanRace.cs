using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RaceHuman", menuName = "ScriptableObjects/RaceHuman", order = 1)]
public class HumanRace : Race
{
    public override RaceType _RaceType => RaceType.Human;
    public override RaceSize RaceSizeType => RaceSize.Medium;
    
}
