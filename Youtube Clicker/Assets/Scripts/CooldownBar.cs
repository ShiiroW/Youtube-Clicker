using UnityEngine;

public class CooldownBar : MonoBehaviour
{

    public ButtonManager b;
    public GameObject jauge, jaugeBout;
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
        Debug.Log(maxWidth);
        basePos = jaugeRect.localPosition;
        realBasePos = transform.position;
        padding *= transform.localScale.x;
        maxWidth -= padding*2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (b.getButton().cooldownStarted)
        {
            Button btn = b.getButton();
            jaugeRect.sizeDelta = new Vector2(maxWidth*(btn.getTimeLeft()/(btn.cooldown*60)), jaugeRect.sizeDelta.y);
            jaugeRect.localPosition = basePos + new Vector3(maxWidth * (btn.getTimeLeft() / (btn.cooldown * 60))/2, 0, 0);

            jaugeBoutRect.localPosition = basePos + new Vector3(maxWidth * (btn.getTimeLeft() / (btn.cooldown * 60)), 0, 0);
        }
    }
}
