using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrounded;
   private Enemy enemyScript;
    // Start is called before the first frame update


    void  OnTriggerEnter2D(Collider2D collider)  

    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = true;
            Debug.Log(collider.gameObject.name);
           
        }
       else if (collider.gameObject.layer == 6)
       {
            enemyScript = collider.gameObject.GetComponent<Enemy>(); // Para que al enemigo en concreto que hemos saltado se rellene con el script de "Enemy"
            enemyScript.Death(); // Llamar a la función death del script del enemigo 

       }
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = true; 
        }
        
    }
    void OnTriggerExit2D(Collider2D collider)
     {
        if(collider.gameObject.layer == 3)
        {
            isGrounded = false;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
