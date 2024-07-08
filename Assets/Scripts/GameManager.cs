using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float gameTime = 60f; // Tiempo total del juego en segundos
    private float timer;
    private bool gameEnded = false;
    public GameTimer gameTimer; // Referencia al script GameTimer
    public LevelManager levelManager; // Referencia al script LevelManager

    void Start()
    {
        timer = gameTime;
        gameTimer.gameTime = gameTime;
    }

    void Update()
    {
        if (!gameEnded)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                EndGame();
            }
        }
    }

    public void EndGame()
    {
        gameEnded = true;
        // Aquí puedes añadir lo que pasa cuando el tiempo se acaba
        Debug.Log("El tiempo se ha acabado!");
        SceneManager.LoadScene("MENU FINAL");
    }

    public void CompleteLevel()
    {
        gameEnded = true;
        levelManager.CompleteLevel();
    }

    public bool IsGameEnded()
    {
        return gameEnded;
    }
}
