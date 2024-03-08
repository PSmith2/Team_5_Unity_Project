using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int health;

    //Audio SFX Call
    AudioManager audioManger;

    private void Awake()
    {
       // audioManger = GameObject.FindGameObjectsWithTag("Audio").GetComponent<AudioManager>();
    }

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



