using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Test : MonoBehaviour
{
    [NonSerialized]
    private Strength _strength = new Strength(14);
    private Dexterity _dexterity = new Dexterity(14);
    public Race _race;

    private void Start()
    {
        print(_race._RaceType);
        print(_race._RaceSize);
        print(_race.RaceSizeType);
    }

    void PrintMyArray(IList array)
    {
        if (array.Count != 0)
        {
            for (int i = 0; i < array.Count; i++)
            {
                print(array[i]);
            }
        }
    }
}
