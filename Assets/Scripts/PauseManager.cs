using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private AudioSource backgroundMusic;
    private bool isPaused = false;
    private string pauseSceneName = "MENU PAUSA"; // Nombre de tu escena de pausa

    void Start()
    {
        backgroundMusic = FindObjectOfType<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        if (SceneManager.GetSceneByName(pauseSceneName).isLoaded)
        {
            SceneManager.UnloadSceneAsync(pauseSceneName).completed += (AsyncOperation op) =>
            {
                Time.timeScale = 1f;
                if (backgroundMusic != null)
                {
                    backgroundMusic.UnPause();
                }
                isPaused = false;
            };
        }
    }

    void PauseGame()
    {
        SceneManager.LoadScene(pauseSceneName, LoadSceneMode.Additive);
        Time.timeScale = 0f;
        if (backgroundMusic != null)
        {
            backgroundMusic.Pause();
        }
        isPaused = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
