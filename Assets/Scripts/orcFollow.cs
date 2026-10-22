using UnityEngine;

public class orcFollow : MonoBehaviour { 
    [SerializeField] private int damage = 1;
    public int Damage => damage;
    [SerializeField] private GameObject player;
    int speed = 40;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = (player.transform.position - transform.position).normalized;
       transform.Translate(direction * speed * Time.deltaTime);
    }
}
