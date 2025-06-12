using UnityEngine;

public class CardScript : MonoBehaviour
{
    public ColorScript color;
    SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        SetColor();
    }

    void SetColor()
    {
        spriteRenderer.sprite = color.sprite;
    }

    void Update()
    {
        SetColor();
    }
}
