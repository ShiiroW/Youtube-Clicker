﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button { 

    public bool isClickacble = true;
    public float cooldown = 5; //EN SECONDES;
    float timeLeft = 5*60;
    public bool cooldownStarted = false;

    public int subGain = 0;
    public int moneyGain = 0;
    public int reputationGain = 0;
    public int videosGain = 0;

    public Button(float cooldown, int subGain, int moneyGain, int reputationGain, int videosGain)
    {
        this.cooldown = cooldown;
        this.subGain = subGain;
        this.moneyGain = moneyGain;
        this.reputationGain = reputationGain;
        this.videosGain = videosGain;
    }

    void OnMouseDown()
    {
        if (isClickacble)
        {
            OnClick();
            StartCooldown();
        }
    }

    public void OnClick()
    {
        if (!isClickacble) return;
        CounterDisplayer.subs += subGain;
        CounterDisplayer.money += moneyGain;
        CounterDisplayer.reputation += reputationGain;
        CounterDisplayer.videos += videosGain;
        StartCooldown();
    }

    public void StartCooldown()
    {
        isClickacble = false;
        timeLeft = 0;
        cooldownStarted = true;
    }

    public void UpdateCooldown()
    {
        if (!cooldownStarted) return;
        timeLeft++;

        if (timeLeft > cooldown*60)
        {
            StopCooldown();
        }

    }

    public void StopCooldown()
    {
        isClickacble = true;
        cooldownStarted = false;
    }

    public float getTimeLeft()
    {
        return timeLeft;
    }

}