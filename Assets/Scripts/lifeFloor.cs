using UnityEngine;

public class lifeFloor : MonoBehaviour
{
    int life = 3;
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
    public void PiedraFall()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D floor) {
        if (floor.gameObject.CompareTag("Piedras"))
        {

            life--;
            anim.SetTrigger("Explosion");
            if (life == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
