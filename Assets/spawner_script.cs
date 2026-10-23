using UnityEngine;
public class spawner_script : MonoBehaviour
{
    public GameObject pipe;
    public float Target_distance=10f;
    private float distance_travelled=0f;
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
            float current_speed = (logic.player_score >5) ? 15f : 5f;
            if (distance_travelled<Target_distance)
            {
                distance_travelled+=current_speed*Time.deltaTime;
            }
            else
            {
                spwan_pipes();
                distance_travelled=0f;
            }
        }
    }
    void spwan_pipes()
    {
        float highest_point=transform.position.y+offset;
        float lowest_point=transform.position.y -offset+3;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowest_point,highest_point),0),transform.rotation);
    }
}
