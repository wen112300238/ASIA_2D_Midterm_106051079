using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("關卡01");
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene("選單");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
