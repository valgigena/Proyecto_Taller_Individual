using JetBrains.Annotations;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;



public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody2D Rb; //esto puede ser distinto

    private float input; //entrada del teclado o joystick
    public float velocidad = 5f;
    
    #region Salto
    [Header("Salto")]
    public LayerMask groundlayer;     // piso
    [Space]
    public float salto = 10;          // potencia de salto
    [SerializeField] bool isGrounded; // true si esta tocando el piso
    public Transform groundCheck;     // Detector de PISO
    
    [Space]
    public float deslizar;            // potencia de deslice
   [SerializeField] bool isWalled;    // true si esta tocando la pared
    public Transform wallCheck;       //Detector de PARED
    #endregion

    void Update()
    {
        //MOVIMIENTO
        input = Input.GetAxisRaw("Horizontal");
        Rb.linearVelocity = new Vector2(velocidad * input, Rb.linearVelocity.y);
       
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,0.1f,groundlayer);
        isWalled = Physics2D.OverlapCircle(wallCheck.position,0.1f,groundlayer);

        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Rb.linearVelocity = new Vector2(Rb.linearVelocity.x, salto);
            AudioManager.instance.PlaySFX(AudioManager.instance.jumpClip);
        
        }
         if(isWalled == true)
        {
            Rb.linearVelocity = new Vector2(Rb.linearVelocity.x,deslizar * -1);
        }
        

        flip();
        
    }

///////////////////////////////////////// Flip ///////////////////////////////////
    private void flip()
    {
        if(input > 0)
        {
            gameObject.transform.localScale = new Vector3(-1,1,1);
        }
          if(input < 0)
        {
            gameObject.transform.localScale = new Vector3(1,1,1);
        }
        
    }

    ///////////////////////////////////////// OnT  ///////////////////////////////////
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "triggerNaranja")
        {
            Debug.Log("OnTriggerEnter2D");
        }        
    }


  private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == "triggerNaranja")
        {
            Debug.Log("OnTriggerExit2D");
        }        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == ("collisionAmarillo"))
        {
        Debug.Log("OnCollisionEnter2D"); // Esto no funcionaba porque la geometria del collider estaba muy justa!!
        }
    }


}