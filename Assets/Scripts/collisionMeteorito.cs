using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class collisionMeteorito : MonoBehaviour
{
    int score;
    [SerializeField] private TextMeshProUGUI tScore;
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

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Rock"))
        {
            score++;
            tScore.text = score.ToString(); 
            Destroy(coll.gameObject);
            Destroy(gameObject);
            anim.SetTrigger("Explosion");
            
            //Score(1);
            
        }

    }
    /*
    public void Score(int sco)
    {
        sco += score;
        tScore.text = score.ToString();
    }
    */

}