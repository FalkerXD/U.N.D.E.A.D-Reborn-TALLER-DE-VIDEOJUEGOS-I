using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameTime = 60f; // Tiempo total de juego en segundos
    private float timer;
    private bool gameEnded = false;

    void Start()
    {
        timer = gameTime;
    }

    void Update()
    {
        // Contar el tiempo
        if (!gameEnded)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;
        // Aquí puedes añadir lo que pasa cuando el tiempo se acaba, por ejemplo:
        // Desactivar movimientos de los mobs, mostrar un mensaje, etc.
        Debug.Log("El tiempo se ha acabado!");
    }

    public bool IsGameEnded()
    {
        return gameEnded;
    }
}
