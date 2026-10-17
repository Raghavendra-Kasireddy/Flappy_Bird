using UnityEngine;
public class spawner_script : MonoBehaviour
{
    public GameObject pipe;
    public float spawn_rate=2;
    private float timer=0;
    public float offset=10;
    public int player_score;
    public locigic_script logic;
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<locigic_script>();
        spwan_pipes();
    }
    void Update()
    {
        if (logic.bird_state){
            if (timer<spawn_rate)
            {
                timer+=Time.deltaTime;
            }
            else
            {
                spwan_pipes();
                timer=0;
            }
        }
    }
    void spwan_pipes()
    {
        float highest_point=transform.position.y+offset;
        float lowest_point=transform.position.y -offset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowest_point,highest_point),0),transform.rotation);
    }
}
