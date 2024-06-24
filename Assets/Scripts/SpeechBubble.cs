using UnityEngine;
using UnityEngine.UI;

public class SpeechBubble : MonoBehaviour
{
    public Text speechText; // Referencia al componente de texto
    public GameObject speechPanel; // Referencia al panel del globo

    void Start()
    {
        // Asegúrate de que el globo de conversación esté oculto al inicio
        speechPanel.SetActive(false);
    }

    // Método para mostrar el globo de conversación
    public void ShowSpeechBubble(string text)
    {
        speechText.text = text;
        speechPanel.SetActive(true);
    }

    // Método para ocultar el globo de conversación
    public void HideSpeechBubble()
    {
        speechPanel.SetActive(false);
    }
}
