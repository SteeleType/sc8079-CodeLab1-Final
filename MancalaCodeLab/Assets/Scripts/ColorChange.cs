using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer.color = GetRandomColor();
    }

    Color GetRandomColor()
    {
        return new Color(Random.Range(0.3f, 1f), Random.Range(0.3f, 1f), Random.Range(0.3f, 1f), 1f);
    }
}
