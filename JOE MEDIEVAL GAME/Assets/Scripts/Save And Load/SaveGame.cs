using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveGame : MonoBehaviour {

    public string fileName = "savegame.txt";

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FPSController")
        {
            var OurFile = File.CreateText(fileName);
            OurFile.WriteLine("savingthegame");
            //OurFile.WriteLine("YouReachedTheVillage");
            OurFile.Close();
        }
    }
}
