using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour
{
    // Método para salir del juego
    public void QuitGame()
    {
        Application.Quit();
        // Si estás probando en el editor de Unity, puedes usar esto para parar la ejecución
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // Método para reiniciar el nivel
    public void RestartLevel()
    {
        // Cargar la escena actual nuevamente
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Método para volver al menú principal
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Asegúrate de que el nombre de la escena del menú principal sea correcto
    }
}
