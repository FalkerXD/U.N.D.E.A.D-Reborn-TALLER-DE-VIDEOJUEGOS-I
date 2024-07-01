using UnityEngine;

public class MobBehavior : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public float speed = 2f; // Velocidad de movimiento del mob
    public int damage = 10; // Daño que el mob inflige al jugador

    void Update()
    {
        // Perseguir al jugador
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Comprobar si la colisión es con el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }

    public void SetPlayer(Transform playerTransform)
    {
        player = playerTransform;
    }
}
