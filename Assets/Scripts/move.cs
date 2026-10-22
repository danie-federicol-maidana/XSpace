using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 25f;
    public Vector2 movementInput;
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private Animator anim;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        movementInput.x = Input.GetAxisRaw("Horizontal");
  
        movementInput = movementInput.normalized;
        anim.SetFloat("Horizontal", movementInput.x);
 
        anim.SetFloat("Speed", movementInput.magnitude);                
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocity = movementInput * speed;
    }
}
