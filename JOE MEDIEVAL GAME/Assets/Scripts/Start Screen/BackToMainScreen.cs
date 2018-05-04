using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMainScreen : MonoBehaviour {

    public GameObject BackToMenu;
	
	// Update is called once per frame
	void Update () {
        BackToMenu.SetActive(true);
	}

    
    public void BacktoMainScreen(string Instruction)
    {
        Application.LoadLevel(0);
    }


}
