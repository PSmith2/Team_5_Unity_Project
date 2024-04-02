using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popups : MonoBehaviour
{
    /*
    public GameObject nextPopup;

    //public float deactivationDelay=10f;

    private void Start()
    {
        Invoke(nameof(DeactivateGameObject), 10);
        Invoke(nameof(ActivateGameObject), 20);
        Invoke(nameof(DeActivateGameObjectPopup), 40);
    }

    private void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }

    private void ActivateGameObject()
    {
        nextPopup.gameObject.SetActive(true);
    }

    private void DeActivateGameObjectPopup()
    {
        nextPopup.gameObject.SetActive(false);
    }
    */
    public GameObject nextPopup1;
    public GameObject nextPopup2;
    public GameObject nextPopup3;

    private void Start()
    {
        StartCoroutine(ManagePopups());
    }

    private IEnumerator ManagePopups()
    {
        // Deactivate the current popup after 10 seconds
        yield return new WaitForSeconds(6f);
        nextPopup1.SetActive(false);

        

        
        nextPopup2.SetActive(true);

        // Deactivate the next popup after 10 seconds
        yield return new WaitForSeconds(5f);
        nextPopup2.SetActive(false);

        nextPopup3.SetActive(true);
        yield return new WaitForSeconds(6f);
        nextPopup3.SetActive(false);
    }

   
}





