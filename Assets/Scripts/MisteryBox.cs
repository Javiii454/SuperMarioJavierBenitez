 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisteryBox : MonoBehaviour


    
  {
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip misteryBoxSFX;
    private bool isOpen = false;
    public AudioClip misteryBoxSFX2;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

    }
    void ActiveBox()
    {
         if(!isOpen)
         {
        animator.SetTrigger("OpenBox");
        audioSource.volume = 1f;
        audioSource.clip = misteryBoxSFX;
        
        isOpen = true;
         }               
        else
        {
        audioSource.clip = misteryBoxSFX2;
        
        }
        audioSource.Play();
    }
    void OnTriggerEnter2D(Collider2D collider)
    
    {
        if(collider.gameObject.CompareTag("Player"))  // Lo mismo que poner gameObject.tag == "Player" 
        {
            ActiveBox();
        }
    }
}
