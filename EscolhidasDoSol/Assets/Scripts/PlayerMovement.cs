using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Velocidade de movimento
                                 
    private Rigidbody rb;

    //variaveis das animações da Iris
    private Animator animator;
    private float vZ = 0f;
    private float vX = 0f;

    public float aceleracao = 2f;
    public float desaceleracao = 2f;

    public float vMaxAndar = 0.5f;
    public float vMaxCorrer = 2.0f;

    private const string KEY_FRONTAL = "w";
    private const string KEY_TRAS = "s";
    private const string KEY_ESQUERDA = "a";
    private const string KEY_DIREITA = "d";
    private const string KEY_CORRER = "left shift";

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        animator = GetComponent<Animator>();
        
    }
    void Update() //Alice (eu) andou mexendo nuns negócio aí 
    {
        // Velocidade inicial
        float currentSpeed = moveSpeed;

        // Verifica se o Shift está pressionado para aumentar a velocidade
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = moveSpeed * 2f; 
        }

        // Movimento no eixo X e Z com WASD
        float moveX = Input.GetAxis("Horizontal") * currentSpeed;
        float moveZ = Input.GetAxis("Vertical") * currentSpeed;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        rb.velocity = new Vector3(move.x, rb.velocity.y, move.z);

        // Controle da animação
        animator.enabled = true;
        AnimationMoviment();
    }

    void AnimationMoviment() 
    {
        bool frente = Input.GetKey(KEY_FRONTAL);
        bool tras = Input.GetKey(KEY_TRAS);
        bool esquerda = Input.GetKey(KEY_ESQUERDA);
        bool direita = Input.GetKey(KEY_DIREITA);
        bool correndo = Input.GetKey(KEY_CORRER);

        float vMaxAtual = correndo ? vMaxCorrer : vMaxAndar;

        // Atualizar velocidades com aceleração/desaceleração
        vZ = AtualizarAnimacao(vZ, frente, tras, vMaxAtual);
        vX = AtualizarAnimacao(vX, direita, esquerda, vMaxAtual);

        // Passar valores para o Animator
        animator.SetFloat("Z", vZ);
        animator.SetFloat("X", vX);
    }
    private float AtualizarAnimacao(float valorAtual, bool positivo, bool negativo, float velocidadeMaxima)
    {
        if (positivo)
        {
            valorAtual = Mathf.Min(valorAtual + Time.deltaTime * aceleracao, velocidadeMaxima);
        }
        else if (negativo)
        {
            valorAtual = Mathf.Max(valorAtual - Time.deltaTime * aceleracao, -velocidadeMaxima);
        }
        else
        {
            // Desaceleração suave quando não há entrada
            if (valorAtual > 0)
            {
                valorAtual = Mathf.Max(valorAtual - Time.deltaTime * desaceleracao, 0);
            }
            else if (valorAtual < 0)
            {
                valorAtual = Mathf.Min(valorAtual + Time.deltaTime * desaceleracao, 0);
            }
        }

        return valorAtual;
    }


}
