using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerCollisionArrow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI tScore;
    int score = 0;
    public int arrow = 10;
   // public int Arrow => arrow;
    int speed = 4;
    [SerializeField] private TextMeshProUGUI tArrow;
    [SerializeField] private GameObject spawnArrow;
    [SerializeField] private GameObject spawnPoint;
    [SerializeField] private IWeapon gun;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (arrow <= 10 && arrow >= 0)
            {
                for (int j = 0; j < 2; j++)
                {
                    Instantiate(spawnArrow, spawnPoint.transform.position, spawnPoint.transform.rotation);
                }
                transform.Translate(0, 5 * speed * Time.deltaTime, 0);
                arrow--;
                tArrow.text = arrow.ToString();

            }
        }



    }

    


}
