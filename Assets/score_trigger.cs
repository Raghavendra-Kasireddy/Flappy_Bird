using Unity.InferenceEngine;
using Unity.VisualScripting;
using UnityEngine;

public class score_trigger : MonoBehaviour
{
    public locigic_script logic;
    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("logic").GetComponent<locigic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        logic.add_score();
    }
}
