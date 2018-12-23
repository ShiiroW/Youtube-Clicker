using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    public BonusManager manager;

    // Start is called before the first frame update
    void Start()
    {
        BonusData.Init();

        Destroy(gameObject);
    }
}
