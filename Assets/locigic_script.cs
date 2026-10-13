using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class locigic_script : MonoBehaviour
{
    public int player_score;
    public Text score_text;
    public GameObject gameover_screen;
    [ContextMenu("increase THE score")]
    public void Start()
    {
       
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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void game_over()
    {
        gameover_screen.SetActive(true);
    }
}
