using UnityEngine;

public class TTLScript : MonoBehaviour
{
    float countDown = 3.0f;

    void Start()
    {
        
    }

    void Update()
    {
        countDown -= Time.deltaTime;
        if (countDown <= 0.0f)
            Destroy(this.gameObject);
    }
}