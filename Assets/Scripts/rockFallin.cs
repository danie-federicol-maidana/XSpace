using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class rockFallin : MonoBehaviour
{
    [SerializeField] private List<GameObject> rock = new List<GameObject>();
    [SerializeField] private List<GameObject> spawn = new List<GameObject>();
        float timeUntilNextEnemy = 5f;
        float time = 0;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {
                time += Time.deltaTime;
                if (timeUntilNextEnemy < time)
                {
                    SpawnNewArrow();
                    time = 0;
                }

                        
    }


    public void SpawnNewArrow()
    {
        int random = Random.Range(0, rock.Count);
        int random2 = Random.Range(0, spawn.Count);
        GameObject a = Instantiate(rock[random], spawn[random2].transform.position,transform.rotation);
    }



}