using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "ScriptableObjects/Weapon", order = 1)]
public class Weapon : Item
{
    private bool _isMelee;
    private bool _isMartial;
    private bool _isFinesse;
    private bool _isNeedLoading;
    private bool _isThrowing;
    private bool _isTwoHanded;
    private bool _isVersatile;
    private bool _isSpecial;
    private WeaponWeight _weaponWeight;
    private int _attackBonus;
    private Damage _damage;
    private WeaponRange _range;
    private Ammunition _ammunition;
}
[CreateAssetMenu(fileName = "MagicWeapon", menuName = "ScriptableObjects/MagicWeapon", order = 1)]
public class MagicWeapon : Weapon
{
    private bool _isNeedAttunement;
    private RaceSkill[] _skillParameters;
    private RaceProficiency[] _proficiencyParameters;
}
[CreateAssetMenu(fileName = "Ammunition", menuName = "ScriptableObjects/Ammunition", order = 1)]
public class Ammunition : Item
{
    private int _bundleSize;
}
public class WeaponRange
{
    private int _normal;
    private int _maximum;
}