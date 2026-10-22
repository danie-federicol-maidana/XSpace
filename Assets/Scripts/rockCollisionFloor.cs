using UnityEngine;


public class rockCollisionFloor : MonoBehaviour
{
    int LifePiso = 1;
    
    [SerializeField] private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {

            Destroy(collision.gameObject);
           anim.SetTrigger("Explosion");
        }
    }

}