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

            Destroy(coll.gameObject);
            Destroy(gameObject);
            anim.SetTrigger("Explosion");
            Score(1);
            tScore.text = score.ToString();
        }

    }

    public void Score(int sco)
    {
        score += sco;
        tScore.text = score.ToString();
    }


}