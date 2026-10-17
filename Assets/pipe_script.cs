using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float movespeed=5;
    private float deadzone=-40;
    public locigic_script logic;
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<locigic_script>();
    }
    void Update()
    {
        if (logic.bird_state==false) movespeed=0;
        transform.position=transform.position+(Vector3.left*movespeed)*Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
            Debug.Log("pipe destroyed past the Deadzone");
        }
        if (logic.player_score>5)
        {
            movespeed=15;
            Debug.Log(movespeed);
        }
    }
}
