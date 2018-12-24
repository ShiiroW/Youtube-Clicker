using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoInitializer : MonoBehaviour
{
    public ButtonManager peuTravaillee, classique, tresTravaillee, sponso;

    // Start is called before the first frame update
    void Start()
    {
        peuTravaillee.cooldown = GameObject.Find("CooldownPeuTravaillee").GetComponent<Cooldown>();
        classique.cooldown = GameObject.Find("CooldownClassique").GetComponent<Cooldown>();
        tresTravaillee.cooldown = GameObject.Find("CooldownTresTravaillee").GetComponent<Cooldown>();
        sponso.cooldown = GameObject.Find("CooldownSponso").GetComponent<Cooldown>();

        Destroy(gameObject);
    }
}
