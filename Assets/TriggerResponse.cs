using UnityEngine;

public class TriggerRsponse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    SpriteRenderer rd;
    Color originalColor;

    void Start()
    {
        rd = GetComponent<SpriteRenderer>();
        originalColor = rd.color;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        rd.color = Color.red;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        rd.color = originalColor;
    }
}
