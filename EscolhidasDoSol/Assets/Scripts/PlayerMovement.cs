using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;      // Velocidade de movimento normal
    public float sprintSpeed = 8f;   // Velocidade ao correr
    private Rigidbody rb;
    private bool canMove = true;     // Controla se o jogador pode se mover

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (canMove) // Executa os comandos somente se puder se mover
        {
            float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? sprintSpeed : moveSpeed;

            float moveX = Input.GetAxis("Horizontal") * currentSpeed;
            float moveZ = Input.GetAxis("Vertical") * currentSpeed;

            Vector3 move = transform.right * moveX + transform.forward * moveZ;
            rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ramp")) // Verifica se tocou na rampa
        {
            canMove = false; // Desativa o movimento
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ramp")) // Verifica se saiu da rampa
        {
            canMove = true; // Reativa o movimento
        }
    }
}
