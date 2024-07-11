using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.UnloadSceneAsync("MENU PAUSA");
        Time.timeScale = 1f;
        AudioSource backgroundMusic = FindObjectOfType<AudioSource>();
        if (backgroundMusic != null)
        {
            backgroundMusic.UnPause();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
