using TMPro;
using UnityEngine;

public class CooldownBar : MonoBehaviour
{

    public ButtonManager b;
    public GameObject jauge, jaugeBout, text;
    RectTransform jaugeRect;
    RectTransform jaugeBoutRect;
    public float maxWidth;
    Vector3 basePos;
    Vector3 realBasePos;

    float padding = 22f;

    // Start is called before the first frame update
    void Start()
    {
        jaugeRect = jauge.GetComponent<RectTransform>();
        jaugeBoutRect = jaugeBout.GetComponent<RectTransform>();
        maxWidth *= transform.localScale.x;
        basePos = jaugeRect.localPosition;
        realBasePos = transform.position;
        padding *= transform.localScale.x;
        maxWidth -= padding*2.5f;

        Button btn = b.getButton();
        jaugeRect.sizeDelta = new Vector2(maxWidth, jaugeRect.sizeDelta.y);
        jaugeRect.localPosition = basePos + new Vector3(maxWidth / 2, 0, 0);

        jaugeBoutRect.localPosition = basePos + new Vector3(maxWidth, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Button btn = b.getButton();
        if (b.getButton().cooldownStarted) { 
        
            jaugeRect.sizeDelta = new Vector2(maxWidth*(btn.getTimeLeft()/(btn.cooldown*60)), jaugeRect.sizeDelta.y);
            jaugeRect.localPosition = basePos + new Vector3(maxWidth * (btn.getTimeLeft() / (btn.cooldown * 60))/2, 0, 0);

            jaugeBoutRect.localPosition = basePos + new Vector3(maxWidth * (btn.getTimeLeft() / (btn.cooldown * 60)), 0, 0);

            text.GetComponent<TextMeshProUGUI>().text = Utils.formatTime((int) ((btn.cooldown-btn.getTimeLeft()/60)));
        }else text.GetComponent<TextMeshProUGUI>().text = Utils.formatTime((int) btn.cooldown);
    }
}
