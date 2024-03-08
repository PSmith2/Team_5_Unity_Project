using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    //Audio SFX Call
    AudioManager audioManager;
    //used to find the specific object
    private void Awake()
    {
        audioManager = GameObject.FindObjectOfType<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;

        
    }
public void TakeDamage(int damage)
    {
        health -= damage;
        audioManager.PlaySFX(audioManager.DamageTaken);

        if (health <= 0) 
        {
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



