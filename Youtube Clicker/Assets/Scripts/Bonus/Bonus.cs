using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus 
{

    public int typeId = 0;
    public float subGainPerSecond;
    public float moneyGainPerSecond;
    float subActualGain = 0;
    float moneyActualGain = 0;

    // Update is called once per frame

    public Bonus(int typeId, float subGainPerSecond, float moneyGainPerSecond) {
        this.typeId = typeId;
        this.subGainPerSecond = subGainPerSecond;
        this.moneyGainPerSecond = moneyGainPerSecond;
    }

    public void Update()
    {
       float subGainFrame = subGainPerSecond / 60;
       subActualGain += subGainFrame;
       if (Mathf.Abs(subActualGain) >= 1)
       {
            CounterDisplayer.subs += (long) Mathf.Round(subActualGain);
            subActualGain = 0;
       }

        float moneyGainFrame = moneyGainPerSecond / 60;
        moneyActualGain += moneyGainFrame;
          if (Mathf.Abs(moneyActualGain) >= 1)
          {
              CounterDisplayer.money += (long) Mathf.Round(moneyActualGain);
              moneyActualGain = 0;
          }
    }
}
