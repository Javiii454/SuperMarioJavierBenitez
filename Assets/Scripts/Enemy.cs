using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int direction = 1;
    public float speed = 5f;
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip EnemySFX;
    private Rigidbody2D rigidbody;
    private BoxCollider2D boxCollider;

    // Start is called before the first frame update
   
   void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
    }
   

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void  FixedUpdate()
    {
        rigidbody.velocity = new Vector2(speed * direction, rigidbody.velocity.y);
    }
    public void Death()
    {
        direction = 0;
        rigidbody.gravityScale = 0;
        animator.SetTrigger("IsDeath");
        boxCollider.enabled = false;
        Destroy(gameObject, 0.3f);
    }
    void  OnCollisionEnter2D(Collision2D collision)
    {
        direction *= -1;

        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
