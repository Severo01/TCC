using UnityEngine;

public class PuloPlayer : MonoBehaviour
{
    public float moveSpeed = 5.0f; //velocidade do personagem 
    public float jumpForce = 10.0f;//Força do pulo
    private Rigidbody rb;
    private bool isGrounded;

    public Transform groundCheck; // um ponto no pé do personagem
    public LayerMask groundLayer; // camada que representa o chão

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         // Movimento horizontal
        float moveX = Input.GetAxis("Horizontal");
        Vector3 velocity = rb.linearVelocity;
        velocity.x = moveX * moveSpeed;
        rb.linearVelocity = velocity;

        // Verifica se está no chão
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);

        // Pulo
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}

