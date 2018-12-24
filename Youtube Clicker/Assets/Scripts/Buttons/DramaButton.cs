using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DramaButton : Button
{
    public DramaButton() : base(300, 0, 0, -10, 0)
    {
        this.subGain = (int) (CounterDisplayer.subs * 0.1);
    }
}
