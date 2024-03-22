using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player"){
            scoreKeeper.incrementScore(500);
            gameObject.SetActive(false);
        }
    }
}
