using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    public BonusManager manager;
    public ButtonManager sub4sub, account, drama, pub;

    // Start is called before the first frame update
    void Start()
    {
        BonusData.Init();

        sub4sub.cooldown = GameObject.Find("CooldownSub4Sub").GetComponent<Cooldown>();
        account.cooldown = GameObject.Find("CooldownAccount").GetComponent<Cooldown>();
        drama.cooldown = GameObject.Find("CooldownDrama").GetComponent<Cooldown>();
        pub.cooldown = GameObject.Find("CooldownPub").GetComponent<Cooldown>();

        Destroy(gameObject);
    }
}
