using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    // M�todo para salir del juego
    public void QuitGame()
    {
        Application.Quit();
        // Si est�s probando en el editor de Unity, puedes usar esto para parar la ejecuci�n
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // M�todo para reiniciar el nivel
    public void RestartLevel()
    {
        // Cargar la escena actual nuevamente
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // M�todo para volver al men� principal
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Aseg�rate de que el nombre de la escena del men� principal sea correcto
    }
}
