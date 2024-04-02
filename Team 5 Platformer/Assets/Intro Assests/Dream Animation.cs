using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamAnimation : MonoBehaviour
{
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;

    
    void Start()
    {
        StartCoroutine(SetUpClouds());


    }

    IEnumerator SetUpClouds()
    {
        // Activate part1 and wait for 5 seconds
        part1.SetActive(true);
        yield return new WaitForSeconds(2);

        // Activate part2 and wait for 5 seconds
        part2.SetActive(true);
        yield return new WaitForSeconds(2);

        // Activate part3
        part3.SetActive(true);
    }
}
