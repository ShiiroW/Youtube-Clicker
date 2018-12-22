using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoutubeClick : MonoBehaviour
{

    static int clickPower = 1;


    private void OnMouseDown()
    {
        CounterDisplayer.subs+=clickPower;
    }
}
