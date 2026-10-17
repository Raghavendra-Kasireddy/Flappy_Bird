using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myridgidbody;
    public float flapstrength;
    public locigic_script logic;
    public bool bird_state=true;

    
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<locigic_script>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bird_state)
        {
            myridgidbody.linearVelocity = Vector2.up*flapstrength;
        }
        if (transform.position.y<=-21 || transform.position.y >= 21)
        {
            bird_state=false;
            logic.game_over();
        }  
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        bird_state=false;
        logic.game_over();
    }
}
