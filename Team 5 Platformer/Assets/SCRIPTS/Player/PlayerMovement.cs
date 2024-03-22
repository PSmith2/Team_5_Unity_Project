using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float platformSpeed = 0f;
    private bool isOnMovingPlatform = false;


    // pause menu
    public GameManager gameManager;

    //Audio SFX Call
    AudioManager audioManager;
    //used to find the specific object
    private void Awake()
    {
        audioManager = GameObject.FindObjectOfType<AudioManager>();
    }


    private Rigidbody2D rb;
    int jumpVelo = 15;
    // Start is called before the first frame update
    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();   
        
    }

    // Update is called once per frame
    private void Update()
    {
        float xPos = Input.GetAxisRaw("Horizontal");
        float yPos = Input.GetAxisRaw("Vertical");

        if(Input.GetButtonDown("Jump"))
        {
            //Plays Jump SFX
            audioManager.PlaySFX(audioManager.Jump);
            rb.velocity = new Vector2(rb.velocity.x, jumpVelo);
            
        }

        rb.velocity = new Vector2(xPos * 10f, rb.velocity.y);

        /*
        if (Input.GetButtonDown("1")) 
        {
            gameManager.gameOver();

        }
        */
    }

    // Called when entering a trigger collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("MovingPlatform"))
        {
            isOnMovingPlatform = true;
            platformSpeed = collision.GetComponent<MovingPlatforms>().speed;
        }
    }

    // Called when exiting a trigger collision
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("MovingPlatform"))
        {
            isOnMovingPlatform = false;
            platformSpeed = 0f;
        }
    }

    // FixedUpdate is called at fixed intervals
    private void FixedUpdate()
    {
        if (isOnMovingPlatform)
        {
            Vector2 platformVelocity = new Vector2(platformSpeed, 0f);
            rb.velocity += platformVelocity;
        }
    }



}
