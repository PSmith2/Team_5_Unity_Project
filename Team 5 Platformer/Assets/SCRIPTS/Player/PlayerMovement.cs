using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    //private float platformSpeed = 0f;
    //private bool isOnMovingPlatform = false;

    public Animator animator;

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
        //calls to make the animation face the right direction
        if (xPos < 0)
        {
            flipLeft();
        }
        else if (xPos > 0)
        {
            flipRight();
        }

        if (Input.GetButtonDown("Jump"))
        {
            //Plays Jump SFX
            audioManager.PlaySFX(audioManager.Jump);
            rb.velocity = new Vector2(rb.velocity.x, jumpVelo);
            animator.SetBool("IsJumping", true);

        }

        rb.velocity = new Vector2(xPos * 10f, rb.velocity.y);

        animator.SetFloat("Speed", Mathf.Abs(xPos));

        if (rb.velocity.y < 1.0) 
        {
            animator.SetBool("IsJumping", false);
        }


    }
    //Flipping calls for Animation

    private void flipLeft()
    {
        if (transform.localScale.x > 0) // Check if already flipped to the left
        {
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }

    private void flipRight()
    {
        if (transform.localScale.x < 0) // Check if already flipped to the right
        {
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }
    }

}
