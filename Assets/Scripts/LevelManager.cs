using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string nextLevelName; // Nombre de la siguiente escena a cargar

    public void CompleteLevel()
    {
        // Cargar la siguiente escena (el menú final en este caso)
        SceneManager.LoadScene(nextLevelName);
    }
}
