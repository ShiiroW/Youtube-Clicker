using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SponsoButton : Button
{

    public SponsoButton(ButtonManager b) : base(0, 0, 5, 1, b)
    {
    }

    public override void OnClick()
    {
        if (base.isAvailable && base.isClickacble)
        {
            moneyGain = CounterDisplayer.subs / 10;
        }
        base.OnClick();
    }
}
