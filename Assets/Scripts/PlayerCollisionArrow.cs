using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollisionArrow : MonoBehaviour
{

    public int arrow = 10;
   // public int Arrow => arrow;
    int speed = 4;
    [SerializeField] private TextMeshProUGUI tArrow;
    [SerializeField] private GameObject spawnArrow;
    [SerializeField] private GameObject spawnPoint;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (arrow <= 10)
            {
                for (int j = 0; j < 2; j++)
                {
                    Instantiate(spawnArrow, spawnPoint.transform.position, spawnPoint.transform.rotation);
                }
                transform.Translate(0, speed * Time.deltaTime, 0);
                arrow--;
                tArrow.text = arrow.ToString();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Arrow"))
        {
            arrow++;    
            Destroy(coll.gameObject);
            tArrow.text = arrow.ToString();

        }
    }



}
