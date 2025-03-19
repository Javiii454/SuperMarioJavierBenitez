using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    public float interpolationRatio = 0.5f;


    // Start is called before the first frame update
    void Awake()
    {
        // Busca un objecto por el nombre que tiene en escena 
       // playerTransform = GameObject.Find("Mario_0").transform;
        //Busca un objeto por tag 
        playerTransform = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = playerTransform.position + offset; // Variable que solo funciona en el Update
        
         float clampX = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x); // Para limitar un valor
         float clampY = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y); 
         Vector3 clampedPosition = new Vector3(clampX,clampY,desiredPosition.z);

         Vector3 lerpedPosition = Vector3.Lerp(transform.position, clampedPosition, interpolationRatio);

         transform.position = lerpedPosition; 
            
       
    }
}
