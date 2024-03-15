using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour //Script pour gerer les différentes scenes
{
    [SerializeField]
    public string sceneName;
    [SerializeField]
    public string Credits;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void CreditsScene()
    {
        SceneManager.LoadScene(Credits);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void Main_Menu()
    {
        SceneManager.LoadScene("Start Menu");
    }
    public void Restart_2()
    {
        SceneManager.LoadScene("Level_2");
    }

}
