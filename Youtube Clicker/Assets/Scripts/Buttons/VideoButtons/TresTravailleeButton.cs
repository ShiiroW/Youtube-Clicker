using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TresTravailleeButton : Button
{

    Bonus bonus;
    BonusManager bonusM;

    public TresTravailleeButton(ButtonManager b, BonusManager bonusM) : base(0, 0, 3f, 1, b)
    {
        this.bonusM = bonusM;
    }

    public override void OnClick()
    {
        if (base.isAvailable && base.isClickacble)
        {
            bonus = BonusData.bonusTypes[0] as Bonus;
            bonusM.AddBonus(0);
        }
        base.OnClick();
    }
}
