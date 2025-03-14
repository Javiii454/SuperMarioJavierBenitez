using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
   public bool isGrounded;
    // Start is called before the first frame update


    void  OnTriggerEnter2D(Collider2D collider)  

    {

       isGrounded = true;
    }
    void OnTriggerStay2D(Collider2D collider)
    {
        isGrounded = true; 
    }
    void OnTriggerExit2D(Collider2D collider)
     {
        isGrounded = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
