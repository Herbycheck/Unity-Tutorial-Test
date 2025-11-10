using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class HealthUIScript : MonoBehaviour
{
    [SerializeField] PlayerData data;
    [SerializeField] RectTransform BackgroundHPBar;
    RectTransform ForegroundHPBar;
    Vector2 newAnchor;

    private void Start()
    {
        data.maxHP = 10;
        data.currentHP = data.maxHP;
        ForegroundHPBar = GetComponent<RectTransform>();
        newAnchor = new Vector2(0, ForegroundHPBar.anchorMax.y);
    }

    private void Update()
    {
        float HPPercent = Mathf.InverseLerp(0,data.maxHP,data.currentHP);
        float newX = Mathf.Lerp(BackgroundHPBar.anchorMin.x,BackgroundHPBar.anchorMax.x,HPPercent);
        newAnchor.x = newX;
        ForegroundHPBar.anchorMax = newAnchor;
    }
}
