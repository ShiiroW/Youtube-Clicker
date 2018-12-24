using System;
using TMPro;
using UnityEngine;

public class CounterDisplayer : MonoBehaviour
{

    public static long subs = 0;
    public static long money = 100;
    public static float reputation = 50f;
    public static long videos = 0;

    public GameObject subText;
    public GameObject moneyText;
    public GameObject reputationText;
    public GameObject videosText;

    // Update is called once per frame
    void Update()
    {
        subText.GetComponent<TextMeshProUGUI>().text = Utils.formatInt(subs);
        moneyText.GetComponent<TextMeshProUGUI>().text = Utils.formatInt(money)+" $";
        reputationText.GetComponent<TextMeshProUGUI>().text = Math.Round(reputation, 1).ToString()+"%";
        videosText.GetComponent<TextMeshProUGUI>().text = Utils.formatInt(videos);
    }

    public void incrementSubs(int inc)
    {
        subs += inc;
    }

    public void setReputation(int rep)
    {
        reputation = (float) Math.Round(reputation, 1);
    }

    public void setVideos(int vid)
    {
        videos = vid;
    }
}
