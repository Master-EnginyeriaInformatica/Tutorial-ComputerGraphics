using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField] public GameObject pref;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {
        // Update is called once per frame
        GameObject obj;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            obj = Instantiate(pref) as GameObject;
            obj.transform.position = transform.position;
        }
    }
    
}
