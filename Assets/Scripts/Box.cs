using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip boxSFX;
    private SpriteRenderer spriteRenderer;
    public BoxCollider2D collider1;
    public BoxCollider2D collider2;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void DestroyBox()
    {
        audioSource.clip = boxSFX;
        audioSource.Play();

        spriteRenderer.enabled = false;
        collider1.enabled = false;
        collider2.enabled = false;

         Destroy(gameObject,boxSFX.length);
    }
  void OnTriggerEnter2D(Collider2D collider)
  {
    if(collider.gameObject.CompareTag("Player"))  // Lo mismo que poner gameObject.tag == "Player" 
    {
       DestroyBox();
    }
  }
   
}
