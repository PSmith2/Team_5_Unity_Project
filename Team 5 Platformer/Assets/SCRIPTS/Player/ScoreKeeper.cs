using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    public int score;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        score = 1000;

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(score.ToString());
    }

    public void decrementScore(int decrement){

        print("decrament");
        score = score - decrement;
    }

    public void incrementScore(int increment){

        score = score + increment;
    }
}
