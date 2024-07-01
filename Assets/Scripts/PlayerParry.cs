using System.Collections;
using UnityEngine;

public class PlayerParry : MonoBehaviour
{
    public float parryWindow = 0.2f; // El tiempo en segundos durante el cual el parry es efectivo
    public float stunDuration = 1f;  // La duración del aturdimiento del enemigo

    private bool isParrying = false;

    void Update()
    {
        // Iniciar el parry si el jugador presiona la tecla P
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(Parry());
        }
    }

    private IEnumerator Parry()
    {
        isParrying = true;

        // Esperar durante el tiempo de ventana del parry
        yield return new WaitForSeconds(parryWindow);

        isParrying = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isParrying && collision.CompareTag("EnemyAttack"))
        {
            // Obtener el componente del enemigo (o el ataque del enemigo)
            Enemy enemy = collision.GetComponentInParent<Enemy>();

            if (enemy != null)
            {
                // Aturdir al enemigo
                enemy.Stun(stunDuration);
            }
        }
    }
}
