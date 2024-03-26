using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    private GameObject originalGameObject;
    private GameObject childObj;

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
            Destroy(gameObject);
        }
    }
}
