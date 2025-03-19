using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody;  // Variables de componentes
    public float playerSpeed = 4.5f;  // Velocidad a la que se mueve
    public float jumpForce = 10;  // Fuerza del salto
    public int direction = 1;  // Si va izquierda o derecha 
    
    public AudioClip jumpSFX;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private GroundSensor _groundSensor; // _ Se puede poner delante para decir que es privado
    private float inputHorizontal;    // Para detectar si pulsamos las teclas de movimiento

    private AudioSource audioSource;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        _groundSensor = GetComponentInChildren<GroundSensor>(); // Para buscar componente en un objeto que esté emparentado a otro 

        spriteRenderer =  GetComponent<SpriteRenderer>(); 
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

    } 
    // Start is called before the first frame update
    void Start()
    {
        // Esto teletransporta al personaje a la posición seleccionada 
        // transform.position = new Vector3(0,0,0);  // Si quieres añadir decimales indicar con f que es un float
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");     //  La diferencia de raw o normal es el tiempo que tarda en frenar el personaje 
        if(Input.GetButtonDown("Jump") && _groundSensor.isGrounded == true)    // Para que al pulsar el space salte y que detecte si está en el suelo o no 
        {
             Jump(); // Llamar funcion Salto
             
        }
        Movement(); // Llamar a la función de movimiento
       animator.SetBool("IsJumping",!_groundSensor.isGrounded); // exclamación delante para invertir el valor de la bool (Si isGrounded es verdadero, Is jumping es falso)
       /*if(_groundSensor.isGrounded)
       {
        animator.SetBool("IsJumping", true);
        else 
        {
        animator.SetBool("IsJumping", false);
        }*/

        // transform.position = new Vector3(transform.position.x + direction * playerSpeed * Time.deltaTime, transform.position.y, transform.position.z);  // Controlador de movimiento del personaje manualmente 

         //transform.Translate (new Vector3(direction * playerSpeed * Time.deltaTime, 0 , 0)); // mover cosas con transfrom, es una función 

         //transform.position =   Vector2.MoveTowards(transform.position, new Vector2(transform.position.x + inputHorizontal ,transform.position.y), playerSpeed * Time.deltaTime);   otro tipo de movimiento de transform// Para plataformas con movimiento

    }
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(inputHorizontal * playerSpeed,rigidbody.velocity.y);
        //rigidbody.AddForce(new Vector2(inputHorizontal, 0));
        //rigidbody.MovePosition(new Vector2(100,0));     // util para mover plataformas en movimiento 
    }

    void Movement()
{

        if(inputHorizontal > 0)
        {
            spriteRenderer.flipX = false;  // Para que el sprite gire dependiendo de donde mire
            animator.SetBool("IsRunning", true); // Para asignar el bool de la animación que quieras
            
        }
        else if(inputHorizontal < 0)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("IsRunning", true);
        }
        else // se ejecuta si ninguna de las demás se cumple
        {
        animator.SetBool("IsRunning", false);
        }
       
}
    void Jump()

{
    rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    audioSource.PlayOneShot(jumpSFX); 
    

}
}





