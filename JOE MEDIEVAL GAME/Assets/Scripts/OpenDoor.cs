using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    public GameObject DoorSwing;
    public GameObject Key;
    public AudioSource KeySound;
    public AudioSource KreekSound;
    public GameObject ThisObject;

    IEnumerator OnMouseDown()
    {
        ThisObject.GetComponent< BoxCollider>().enabled = false;
        ThisObject.GetComponent<MeshCollider>().enabled = false;
        Key.SetActive(false);
        KeySound.Play();
        yield return new WaitForSeconds(1f);
        KreekSound.Play();
        DoorSwing.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.99f);
        DoorSwing.GetComponent<Animator>().enabled = false;
        
       


    }

    // Update is called once per frame
    void Update () {
		
	}
}
