using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    public SpeechBubble speechBubble;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Muestra el globo de conversación con el texto deseado
            speechBubble.ShowSpeechBubble("¡Hola, bienvenido a nuestro mundo!");
        }
    }
}
