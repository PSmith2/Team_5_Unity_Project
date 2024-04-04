using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EngGate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player"){

            if (SceneManager.GetActiveScene().ToString() == "Intro Scene"){
                SceneManager.LoadScene("Tutorial Level");
            }
            SceneManager.LoadScene("Main Menu");
        }
    }
}
