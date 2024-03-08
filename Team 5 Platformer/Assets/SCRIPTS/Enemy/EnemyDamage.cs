using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage;
    public PlayerHealth playerHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {

            if (!IsFeetCollision(collision))
            {
                playerHealth.TakeDamage(damage);

            }
        }
    }


    // Helper method to check if the collision involves the feet of the player
    private bool IsFeetCollision(Collision2D collision)
    {
        foreach (ContactPoint2D contact in collision.contacts)
        {
            if (contact.collider.CompareTag("Feet"))
            {
                return true;
            }
        }
        return false;
    }
}

