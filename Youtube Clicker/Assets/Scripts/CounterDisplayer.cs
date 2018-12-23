using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterDisplayer : MonoBehaviour
{

    public static int subs = 0;
    public static int money = 0;
    public static int reputation = 0;
    public static int videos = 0;

    public GameObject subText;
    public GameObject moneyText;
    public GameObject reputationText;
    public GameObject videosText;

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

    public void setReputation(int rep)
    {
        reputation = rep;
        reputationText.GetComponent<TextMeshProUGUI>().text = reputation.ToString();
    }

    public void setVideos(int vid)
    {
        videos = vid;
        videosText.GetComponent<TextMeshProUGUI>().text = videos.ToString();
    }
}
