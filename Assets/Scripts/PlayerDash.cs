using System.Collections;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float dashSpeed = 20f; // La velocidad del dash
    public float dashTime = 0.2f; // La duración del dash
    public float dashCooldown = 1f; // El tiempo de espera entre dashes

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private bool isDashing;
    private bool canDash = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isDashing)
        {
            // Obtener el input de movimiento del jugador
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            moveDirection = new Vector2(moveX, moveY).normalized;
        }

        // Iniciar el dash si el jugador presiona la tecla F y puede dashear
        if (Input.GetKeyDown(KeyCode.F) && canDash)
        {
            StartCoroutine(Dash());
        }
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;

        // Aplicar la velocidad de dash
        rb.velocity = moveDirection * dashSpeed;

        yield return new WaitForSeconds(dashTime);

        // Detener el dash
        rb.velocity = Vector2.zero;
        isDashing = false;

        // Esperar el cooldown antes de permitir otro dash
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }
}
