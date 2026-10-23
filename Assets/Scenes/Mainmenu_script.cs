using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu_script : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("Game_scene");
    }
}
