using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class FlechasSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> arrow = new List<GameObject>();
    [SerializeField] private List<GameObject> spawn = new List<GameObject>();
        float timeUntilNextEnemy = 10f;
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
        int random = Random.Range(0, arrow.Count);
        int random2 = Random.Range(0, spawn.Count);
        GameObject a = Instantiate(arrow[random], spawn[random2].transform.position,transform.rotation);
    }



}