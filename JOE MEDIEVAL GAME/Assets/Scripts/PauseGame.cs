using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {

    public GameObject PauseMenu;

    public GameObject ResumeGame;
    public GameObject SaveGame;
    public GameObject ExitGame;

    public GameObject ThePlayer;
    public bool Paused = false;

    //private void Start()
    //{
    //    Debug.Log("startScreen");
    //}

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(Paused == false)
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0;
                Paused = true;
                ThePlayer.GetComponent<FirstPersonController>().enabled = false;
                Cursor.visible = true;
            }
            else
            {
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                Paused = false;
                Time.timeScale = 1;
                PauseMenu.SetActive(false);
                Cursor.visible = false;
            }

        }
    }

    //create function for user to resume game
    public void BackToGame()
    {
        // if( ResumeGame == true)
        //{
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        Paused = false;
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        Cursor.visible = false;
       // }
    }

    //create function is SaveGame button is pressed to allow user to save the game
    public void SaveTheGame()
    {

    }

    //function to allow user to exit game and allow to get back to the main screen
    public void ExitTheGame(string startScreen)
    {
        Application.LoadLevel(0);
        //Debug.Log("startScreen" + startScreen);
        //SceneManager.LoadScene(startScreen);
    }
}
