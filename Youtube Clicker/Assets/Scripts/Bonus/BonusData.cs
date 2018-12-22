using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusData
{
    public static ArrayList bonusTypes = new ArrayList();

    public static void Init()
    {
        bonusTypes.Add(new Bonus(0, 0.5f, 0));
        bonusTypes.Add(new Bonus(1, 10f, 5f));
    }
}
