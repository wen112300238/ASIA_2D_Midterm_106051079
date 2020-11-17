using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StarGame()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡01");
    }
    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
