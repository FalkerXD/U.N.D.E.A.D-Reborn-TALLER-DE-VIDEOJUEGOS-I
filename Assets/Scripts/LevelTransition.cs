using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    [SerializeField] private string sceneName;  // El nombre de la escena a la que quieres transicionar

    // Este método se llama cuando otro objeto colisiona con el objeto que tiene este script
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificamos si el objeto que colisionó es el jugador
        if (other.CompareTag("Player"))
        {
            // Cargar la nueva escena
            SceneManager.LoadScene(sceneName);
        }
    }
}
