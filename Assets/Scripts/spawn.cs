using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class spawn : MonoBehaviour
{
   [SerializeField] private List <GameObject> enemys = new List <GameObject>();
   [SerializeField] private List <GameObject> spawnPoint = new List<GameObject>();
    int timeUntilNextEnemy = 4;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeUntilNextEnemy)
        {
            spawnEnemy();
            timer = 0;
        }
    }
    public void spawnEnemy() {
        int random = Random.Range(0, enemys.Count());
        int random2 = Random.Range(0, spawnPoint.Count());
        GameObject a = Instantiate(enemys[random], spawnPoint[random2].transform.position, transform.rotation);
        timeUntilNextEnemy = Random.Range(1, 2)
    ;   
    }

}
