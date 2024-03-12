using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour //Script pour gerer les différentes scenes
{
    [SerializeField]
    public string sceneName;
    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
