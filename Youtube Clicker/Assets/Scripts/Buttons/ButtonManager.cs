using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    public String buttonType;
    public bool buttonAvailable = true;
    CanvasGroup canvasGroup;
    public Cooldown cooldown;
    Button b;
    Vector2 baseSize;
    bool animationStart = false;
    int frame = 0;

    public CooldownBar cooldownBar;

    Sprite spr;
    public Sprite cadenasSprite;

    // Start is called before the first frame update
    void Start()
    {

        spr = GetComponent<Image>().sprite;

        if (buttonType == "CreateAccount")
        {
            b = new AccountButton(this);
            b.isAvailable = buttonAvailable;
        }
        else if (buttonType == "Sub4Sub")
        {
            b = new Sub4SubButton(this);
            b.isAvailable = buttonAvailable;
        }
        else if (buttonType == "Drama")
        {
            b = new DramaButton(this);
            b.isAvailable = buttonAvailable;
        }
        else if (buttonType == "Pub")
        {
            b = new PubButton(this);
            b.isAvailable = buttonAvailable;
        }
        else if (buttonType == "PeuTravaillee")
        {
            b = new PeuTravailleeButton(this, GameObject.Find("BonusManager").GetComponent<BonusManager>());
            b.isAvailable = buttonAvailable;
        }
        else if (buttonType == "Classique")
        {
            b = new ClassiqueButton(this, GameObject.Find("BonusManager").GetComponent<BonusManager>());
            b.isAvailable = buttonAvailable;
        }
        else if (buttonType == "TresTravaillee")
        {
            b = new TresTravailleeButton(this, GameObject.Find("BonusManager").GetComponent<BonusManager>());
            b.isAvailable = buttonAvailable;
        }

        canvasGroup = GetComponent<CanvasGroup>();
        baseSize = GetComponent<RectTransform>().sizeDelta;
    }

    // Update is called once per frame
    void Update()
    {
        if (!b.isAvailable)
        {
            GetComponent<Image>().sprite = cadenasSprite;
            canvasGroup.alpha = 0.5f;
            cooldownBar.GetComponent<CanvasGroup>().alpha = 0;
        }
        else
        {
            GetComponent<Image>().sprite = spr;
            cooldownBar.GetComponent<CanvasGroup>().alpha = 1;
            if (cooldown.cooldownStarted)
            {
                b.isClickacble = false;
                canvasGroup.alpha = 0.5f;
            }
            else
            {
                canvasGroup.alpha = 1;
                b.isClickacble = true;
            }
        }

        if (animationStart && frame <= 5)
        {
            frame++;
            float spd = -(1.1f / 50)*frame;
            GetComponent<RectTransform>().sizeDelta = baseSize * (spd+1);
        }

        b.isAvailable = b.CheckUnlock();
    }

    void OnMouseUp()
    {
        if (b.isAvailable) b.OnClick();
        GetComponent<RectTransform>().sizeDelta = baseSize;
        frame = 0;
        animationStart = false;
    }

    void OnMouseDown()
    {
        GetComponent<RectTransform>().sizeDelta /= 1.1f;
        animationStart = true;
    }

    public Button getButton()
    {
        return b;
    }
}
