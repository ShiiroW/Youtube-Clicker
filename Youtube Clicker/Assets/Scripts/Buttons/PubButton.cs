using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubButton : Button
{
    public PubButton() : base(600, 2, 0, -0.3f, 0)
    {
    }

    public override void OnClick()
    {
        subGain = (long)Mathf.Round(10 * (CounterDisplayer.reputation/100));
        base.OnClick();
    }
}
