using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    private Sprite _icon;
    private string _name;
    private Rarity _rarity;
    private string _description;
    private int _cost;
    private int _weight;
}
[CreateAssetMenu(fileName = "MagicItem", menuName = "ScriptableObjects/MagicItem", order = 1)]
public class MagicItem : Item
{
    private bool _isNeedAttunement;
    private RaceSkill[] _skillParameters;
    private RaceProficiency[] _proficiencyParameters;
}
[CreateAssetMenu(fileName = "Armor", menuName = "ScriptableObjects/Armor", order = 1)]
public class Armor : Item
{
    private int _armorClass;
    private ArmorType _armorType;
}
[CreateAssetMenu(fileName = "Tool", menuName = "ScriptableObjects/Tool", order = 1)]
public class Tool : Item
{
    
}