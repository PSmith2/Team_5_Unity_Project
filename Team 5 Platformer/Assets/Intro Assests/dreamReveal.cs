using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dreamReveal : MonoBehaviour
{
    public GameObject DreamObj;


    private void OnTriggerEnter2D(Collider2D collision)
    
    {
        if (collision.CompareTag("Player"))
        {
            DreamObj.SetActive(true);
            
        }

    }
}
