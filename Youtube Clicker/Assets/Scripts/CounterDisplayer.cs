using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterDisplayer : MonoBehaviour
{

    public static int subs = 0;
    public static int money = 0;

    public GameObject subText;
    public GameObject moneyText;

    // Update is called once per frame
    void Update()
    {
        subText.GetComponent<TextMeshProUGUI>().text = subs.ToString();
        moneyText.GetComponent<TextMeshProUGUI>().text = money.ToString();
    }

    public void incrementSubs(int inc)
    {
        subs += inc;
    }
}
