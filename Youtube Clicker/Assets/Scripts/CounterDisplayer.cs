using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterDisplayer : MonoBehaviour
{

    public static long subs = 0;
    public static long money = 0;
    public static float reputation = 0;
    public static long videos = 0;

    public GameObject subText;
    public GameObject moneyText;
    public GameObject reputationText;
    public GameObject videosText;

    // Update is called once per frame
    void Update()
    {
        subText.GetComponent<TextMeshProUGUI>().text = Utils.formatInt(subs);
        moneyText.GetComponent<TextMeshProUGUI>().text = Utils.formatInt(money);
    }

    public void incrementSubs(int inc)
    {
        subs += inc;
    }

    public void setReputation(int rep)
    {
        reputation = rep;
        reputationText.GetComponent<TextMeshProUGUI>().text = reputation.ToString();
    }

    public void setVideos(int vid)
    {
        videos = vid;
        videosText.GetComponent<TextMeshProUGUI>().text = Utils.formatInt(videos);
    }
}
