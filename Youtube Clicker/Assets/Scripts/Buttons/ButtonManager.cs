using System;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{

    public String buttonType;
    CanvasGroup canvasGroup;
    public Cooldown cooldown;
    Button b;
    Vector2 baseSize;
    bool animationStart = false;
    int frame = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (buttonType == "CreateAccount")
        {
            b = new AccountButton(this);
        }else if (buttonType == "Sub4Sub")
        {
            b = new Sub4SubButton(this);
        }
        else if (buttonType == "Drama")
        {
            b = new DramaButton(this);
        }
        else if (buttonType == "Pub")
        {
            b = new PubButton(this);
        }

        canvasGroup = GetComponent<CanvasGroup>();
        baseSize = GetComponent<RectTransform>().sizeDelta;
    }

    // Update is called once per frame
    void Update()
    {
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

        if (animationStart && frame <= 5)
        {
            frame++;
            float spd = -(1.1f / 50)*frame;
            GetComponent<RectTransform>().sizeDelta = baseSize * (spd+1);
        }
    }

    void OnMouseUp()
    {
        b.OnClick();
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
