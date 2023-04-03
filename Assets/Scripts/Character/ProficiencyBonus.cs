using UnityEngine;

public class ProficiencyBonus
{
    private static int pBonusValue = 2; 
    
    public static int BonusValue
    {
        get
        {
            return pBonusValue;
        }
        set
        {
            SetValue(value);
        }
    }

    public static int GetValue()
    {
        return pBonusValue;
    }
    private static int SetValue(int value)
    {
        if (value < 2) value = 2;
        else if (value > 6) value = 6;
        pBonusValue = value;
        return pBonusValue;
    }
    public static int SetValueByLevel(int level)
    {
        int val = Mathf.CeilToInt(level * 0.25f) + 1;
        SetValue(val);
        return pBonusValue;
    }    
}
