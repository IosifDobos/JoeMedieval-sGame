using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreen  : MonoBehaviour {

    //public string fileName = "savegame.txt";
    //public string LoadCode;
    //public string GlobalLoad;
    //public GameObject NoSaveData;


    void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * 2f, Space.World);
	}

    public void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2, 100, 30), "Play Game"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 40, 100, 30), "Load Game"))
        {
            //GlobalLoad = LoadCode;

            //if (GlobalLoad == "savingthegame")
            //{
                Application.LoadLevel(1);
            //}
            //else
            //{
            //    NoSaveData.SetActive(true);
            //}
            //Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 80, 100, 30), "Instructions"))
        {
            Application.LoadLevel(2);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 50, Screen.height / 2 + 120, 100, 30), "Quit Game"))
        {
            Application.Quit();
        }

        
    }
}
