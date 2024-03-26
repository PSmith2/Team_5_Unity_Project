using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    
    
    public int damage = 1;

    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    // Start is called before the first frame update
    void Start()
    {


        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");

        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x, moveDir.y);
        Destroy(this.gameObject, 2);

    }
    /*
     Add a on trigger collider for removing player health
*/
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            var playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
                playerHealth.TakeDamage(damage);
        }
    }
}
