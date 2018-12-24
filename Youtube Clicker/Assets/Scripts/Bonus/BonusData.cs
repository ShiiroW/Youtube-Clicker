using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusData
{
    public static ArrayList bonusTypes = new ArrayList();

    public static void Init()
    {
        bonusTypes.Add(new Bonus(0, 1.5f, 1f)); //VIDEO PEU TRAVAILLEE
        bonusTypes.Add(new Bonus(1, 1.5f, 1f)); //VIDEO CLASSIQUE
        bonusTypes.Add(new Bonus(2, 1.5f, 1f)); //VIDEO TRES TRAVAILLEE
        bonusTypes.Add(new Bonus(3, 1.5f, 1f)); //VIDEO SPONSO
    }
}
