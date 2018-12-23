using System;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public String buttonType;
    Button b;

    // Start is called before the first frame update
    void Start()
    {
        if (buttonType == "CreateAccount")
        {
            b = new AccountButton();
        }else if (buttonType == "Sub4Sub")
        {
            b = new Sub4SubButton();
        }
        else if (buttonType == "Drama")
        {
            b = new DramaButton();
        }
    }

    // Update is called once per frame
    void Update()
    {
        b.UpdateCooldown();
    }

    void OnMouseDown()
    {
        b.OnClick();
    }

    public Button getButton()
    {
        return b;
    }
}
