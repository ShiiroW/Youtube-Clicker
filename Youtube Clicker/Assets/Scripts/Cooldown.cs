using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MonoBehaviour
{

    public float cooldown = 5; //EN SECONDES;
    float timeLeft = 5 * 60;
    public bool cooldownStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void StartCooldown()
    {
        timeLeft = 0;
        cooldownStarted = true;
    }

    public void Update()
    {
        if (!cooldownStarted) return;
        timeLeft++;

        if (timeLeft > cooldown * 60)
        {
            StopCooldown();
        }

    }

    public void StopCooldown()
    {
        cooldownStarted = false;
    }

    public float getTimeLeft()
    {
        return timeLeft;
    }
}
