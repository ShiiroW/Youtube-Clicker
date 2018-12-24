using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubButton : Button
{
    public PubButton(ButtonManager b) : base(2, 0, -0.3f, 0, b)
    {
    }

    public override void OnClick()
    {
        if (base.isAvailable && base.isClickacble) subGain = (long)Mathf.Round(10 * (CounterDisplayer.reputation/100));
        base.OnClick();
    }
}
