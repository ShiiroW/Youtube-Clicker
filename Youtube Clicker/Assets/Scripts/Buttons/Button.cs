using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button {

    public bool isClickacble = true;

    public ButtonManager b;

    public long subGain = 0;
    public long moneyGain = 0;
    public float reputationGain = 0;
    public long videosGain = 0;

    public Button(long subGain, long moneyGain, float reputationGain, long videosGain, ButtonManager b)
    {
        this.subGain = subGain;
        this.moneyGain = moneyGain;
        this.reputationGain = reputationGain;
        this.videosGain = videosGain;
        this.b = b;
    }

    void OnMouseDown()
    {
        if (isClickacble)
        {
            OnClick();
            b.cooldown.StartCooldown();
        }
    }

    public virtual void OnClick()
    {
        if (!isClickacble) return;
        CounterDisplayer.subs += subGain;
        CounterDisplayer.money += moneyGain;
        CounterDisplayer.reputation += reputationGain;
        CounterDisplayer.videos += videosGain;
        b.cooldown.StartCooldown();
    }


}
