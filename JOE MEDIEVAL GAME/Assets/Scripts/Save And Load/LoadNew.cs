using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadNew : MonoBehaviour {

    public string fileName = "savegame.txt";
    public  string LoadCode;
    public  string GlobalLoad;
    public GameObject NoSaveData;

    string line;

    private void Start()
    {
        StreamReader OurFile = new StreamReader(fileName);

        line = OurFile.ReadLine();
        while(line != null)
        {
            LoadCode = line;
            line = OurFile.ReadLine();
        }
        OurFile.Close();
    }

    void NewGame()
    {
        GlobalLoad = "";
        Application.LoadLevel(1);
    }

    void LoadGame()
    {
        GlobalLoad = LoadCode;

        if(GlobalLoad == "savingthegame")
        {
            Application.LoadLevel(1);
        }
        else
        {
            NoSaveData.SetActive(true);
        }
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
