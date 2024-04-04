 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject gameOverUI;
    public GameObject LevelCompleteUI;

    // Start is called before the first frame update
    void Start()
    {
        //hide the cursor and lock it in place
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Show and unlock cursor if in menu mode
        if(gameOverUI.activeInHierarchy || LevelCompleteUI.activeInHierarchy)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        } else 
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void gameOver(){
        
        gameOverUI.SetActive(true);
    }

    public void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    //Quit level (doesnt work in editor)
    public void quit()
    {
        Application.Quit();
    }

    public void openMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
