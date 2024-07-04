using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float gameTime = 60f; // Tiempo total del juego en segundos
    private float timer;
    public Text timerText; // Referencia al componente Text

    void Start()
    {
        timer = gameTime;
        UpdateTimerText();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                timer = 0;
            }
            UpdateTimerText();
        }
    }

    void UpdateTimerText()
    {
        // Formato del tiempo (mm:ss)
        int minutes = Mathf.FloorToInt(timer / 60F);
        int seconds = Mathf.FloorToInt(timer % 60F);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }
}
