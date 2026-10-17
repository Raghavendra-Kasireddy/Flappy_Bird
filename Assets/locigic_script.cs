using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class locigic_script : MonoBehaviour
{
    public int player_score;
    public Text score_text;
    public GameObject gameover_screen;
    public pipe_script pipes;
    public bool bird_state;
    [ContextMenu("increase THE score")]
    public void Start()
    {
       pipes=GetComponent<pipe_script>();
       bird_state=true;
    }
    public void Update()
    {
        Debug.Log(player_score);
    }
    public void add_score()
    {
        player_score+=1;
        score_text.text=player_score.ToString();
    }
    public void restart_game()
    {
        bird_state=true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void game_over()
    {
        bird_state=false;
        gameover_screen.SetActive(true);
    }
}
