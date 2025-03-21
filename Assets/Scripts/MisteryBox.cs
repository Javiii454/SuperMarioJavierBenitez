 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisteryBox : MonoBehaviour


    
  {
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip misteryBoxSFX;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();

    }
    void ActiveBox()
    {
        animator.SetTrigger("OpenBox");
        audioSource.clip = misteryBoxSFX;
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
