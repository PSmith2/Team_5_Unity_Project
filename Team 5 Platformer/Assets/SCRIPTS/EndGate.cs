using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EngGate : MonoBehaviour
{
     public GameObject LevelCompleteUI;
     public GameObject Player;

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
           
            //Pause the game and freeze player on level complete
            Time.timeScale=0;
            Player.GetComponent<PlayerMovement>().enabled = false;
            LevelCompleteUI.SetActive(true);

        }
    }
}
