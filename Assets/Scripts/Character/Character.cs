using UnityEngine;

public abstract class Character
{
    //Base values
    private Level _characterLevel;
    private ProficiencyBonus _characterProficiencyBonus;
    private Sprite _characterAvatar;
    private string _characterName;
    private CharacterClass _characterClass;
    private Race _characterRace;
    private Gender _characterGender;
    private int _passivePerception;
    private int _passiveInvestigation;
    private int _passiveInsight;
    //Skill values
    private Strength _characterStrength;
    private Constitution _characterConstitution;
    private Dexterity _characterDexterity;
    private Intelligence _characterIntelligence;
    private Wisdom _characterWisdom;
    private Charisma _characterCharisma;
    //Battle values
    private int _characterInitiative;
    private int _characterArmorClass;
    private int _characterInspiration;
    private Condition[] _characterConditions;
    private DamageType[] _characterResistances;
    private DamageType[] _characterImmunities;
    //Feats
    private Feat[] _characterFeats;
    //Items
    private Item[] _characterItems;
    private int _characterCarriedWeight;
    private Currency _characterCurrency;
    //Weapons
    private Weapon[] _characterWeapons;
    private Armor _characterArmor;
    
}
