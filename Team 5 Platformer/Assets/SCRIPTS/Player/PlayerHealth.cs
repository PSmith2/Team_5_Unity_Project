using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{

    public GameManager gameManager;
    public int maxHealth = 3;
    public int health;
 
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;

        
    }
public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0) 
        {
            gameManager.gameOver();
            HealthManager.health--;
            Destroy(gameObject);
        }
        HealthManager.health--;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
