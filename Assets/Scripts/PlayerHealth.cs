using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public HealthBar healthBar; // Referencia a la barra de vida

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); // Inicializar la barra de vida
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth, maxHealth); // Actualizar la barra de vida

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }
        Debug.Log("Player Health: " + currentHealth);
    }

    void Die()
    {
        // Aquí desaparecemos al jugador
        gameObject.SetActive(false);
        // Cambiamos a la escena de Game Over
        SceneManager.LoadScene("MENU GAME OVER");
    }
}
