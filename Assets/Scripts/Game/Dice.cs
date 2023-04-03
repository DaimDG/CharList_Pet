using UnityEngine;
using UnityEngine.UIElements;

public struct Dice
{
    private DiceType _diceID;

    public Dice(DiceType diceType)
    {
        if (diceType == 0) diceType = DiceType.D4;
        _diceID = diceType;
    }

    public int ThrowNewDice(DiceType diceType)
    {           
        int randomValue = Random.Range(1, (int)diceType + 1);
        return randomValue;
    }
    public int ThrowThisDice()
    {
        if (_diceID == 0)
        {
            Debug.Log("Dice type not selected! Using default value (d4)!" );
            _diceID = DiceType.D4;
        }
        int randomValue = Random.Range(1, (int)_diceID + 1);
        return randomValue;
    }
}    
