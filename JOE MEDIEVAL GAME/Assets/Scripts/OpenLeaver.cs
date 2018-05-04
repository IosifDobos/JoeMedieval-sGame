using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLeaver : MonoBehaviour {

    public GameObject TheLeaver;
    public AudioSource LeaverSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        TheLeaver.GetComponent<BoxCollider>().enabled = false;
        TheLeaver.GetComponent<Animation>().Play("EntranceAnim");
        LeaverSound.Play();
    }
}
