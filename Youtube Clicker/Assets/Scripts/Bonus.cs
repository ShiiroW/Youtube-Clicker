using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus 
{

    public int typeId = 0;
    public bool gainSubs = true; //SI TRUE : AUGMENTE LES SUBS
    public bool gainMoney = true; //SI TRUE : AUGMENTE L'ARGENT
    public float subGainPerSecond;
    public float moneyGainPerSecond;
    float subActualGain = 0;
    float moneyActualGain = 0;

    // Update is called once per frame

    public Bonus(int typeId, bool gainSubs, bool gainMoney, float subGainPerSecond, float moneyGainPerSecond) {
        this.typeId = typeId;
        this.gainSubs = gainSubs;
        this.gainMoney = gainMoney;
        this.subGainPerSecond = subGainPerSecond;
        this.moneyGainPerSecond = moneyGainPerSecond;
    }

    public void Update()
    {
        if (gainSubs)
        {
            float subGainFrame = subGainPerSecond / 60;
            subActualGain += subGainFrame;
            if (Mathf.Abs(subActualGain) >= 1)
            {
                CounterDisplayer.subs += (int) Mathf.Round(subActualGain);
                subActualGain = 0;
            }
        }
        if (gainMoney)
        {
            float moneyGainFrame = moneyGainPerSecond / 60;
            moneyActualGain += moneyGainFrame;
            if (Mathf.Abs(moneyActualGain) >= 1)
            {
                CounterDisplayer.money += (int) Mathf.Round(moneyActualGain);
                moneyActualGain = 0;
            }
        }
    }
}
