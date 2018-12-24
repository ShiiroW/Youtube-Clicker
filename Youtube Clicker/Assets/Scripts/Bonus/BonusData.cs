using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusData
{
    public static ArrayList bonusTypes = new ArrayList();

    public static void Init()
    {
        bonusTypes.Add(new Bonus(0, 1.5f, 1f));
    }
}
