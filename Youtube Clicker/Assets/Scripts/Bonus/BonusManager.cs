using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusManager : MonoBehaviour
{

    public static ArrayList bonusList = new ArrayList();

    // Update is called once per frame
    void Update()
    {
        foreach (Bonus bonus in bonusList)
        {
            bonus.Update();
        }
    }

    public void AddBonus(Bonus bonus)
    {
        bonusList.Add(bonus);
    }

    public void AddBonus(int type)
    {
        bonusList.Add(BonusData.bonusTypes[type]);
    }
}
