using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public Transform platform;
    public Transform PosA;
    public Transform PosB;
    public float speed;
    public Vector3 targetPos;


   
    



    private void Start()
    {
        targetPos = PosB.position;
      


    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, PosA.position) < 0.05f) 
        {
            targetPos = PosB.position;
            


        }

        if (Vector2.Distance(transform.position, PosB.position) < 0.05f) 
        {
            targetPos = PosA.position;
           


        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

/*
    private void FixedUpdate()
    {
        rb.velocity = moveDirection * speed;
    }

    void DirectionCalculate() 
    {
        moveDirection = (targetPos - transform.position).normalized;
    }

    */




    private void OnDrawGizmos()
    {
        if(platform!=null && PosA!=null && PosB != null)
        {
            Gizmos.DrawLine(platform.transform.position, PosA.position);
            Gizmos.DrawLine(platform.transform.position, PosB.position);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            collision.transform.parent = this.transform;
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.parent = null;
        }
    }
    
}
