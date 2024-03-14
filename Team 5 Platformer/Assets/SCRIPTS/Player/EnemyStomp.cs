using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStomp : MonoBehaviour
{

    public ScoreKeeper scoreKeeper;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "WeakPoint")
        {   
            print("decrament");
            scoreKeeper.decrementScore(100);
            Destroy(collision.gameObject);
        }
    }
}
