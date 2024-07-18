using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Resume()
    {
        if (SceneManager.GetSceneByName("MENU PAUSA").isLoaded)
        {
            SceneManager.UnloadSceneAsync("MENU PAUSA").completed += (AsyncOperation op) =>
            {
                Time.timeScale = 1f;
                AudioSource backgroundMusic = FindObjectOfType<AudioSource>();
                if (backgroundMusic != null)
                {
                    backgroundMusic.UnPause();
                }
            };
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
