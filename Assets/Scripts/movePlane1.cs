using UnityEngine;

public class movePlane1 : MonoBehaviour
{
  

    int speeds = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
            
    // Update is called once per frame
    void Update()
    {
        transform.Translate(10 * speeds * Time.deltaTime,0,0);
    }
}
