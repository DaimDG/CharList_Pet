using System.Data;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Spell: ScriptableObject
{
    private Sprite _icon;
    private string _name;
    private string _description;
    private int _spellLevel;
    private DamageType[] _damageTypes;
    //private Damage
    private CharacterClassType[] _characterClassNeeded;
}
