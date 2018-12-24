using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DramaButton : Button
{
    public DramaButton(ButtonManager b) : base(0, 0, -10, 0, b)
    {
        this.subGain = (int) (CounterDisplayer.subs * 0.1);
    }

    public override void OnClick()
    {
        if (base.isAvailable && base.isClickacble) this.subGain = (int)(CounterDisplayer.subs * 0.1);
        base.OnClick();
    }

    public override bool CheckUnlock()
    {
        return CounterDisplayer.subs >= 10;
    }
}
