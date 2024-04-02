using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLVL1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player collided with trigger.");

            SceneManager.LoadSceneAsync("Tutorial Level");
        }

    }
}
