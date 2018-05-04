using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaStart : MonoBehaviour {

    public GameObject BlackScreen;
    public GameObject FadeScreen;

    private void Start()
    {
        Cursor.visible = false;
        Screen.lockCursor = true;
        //Cursor.lockState = CursorLockMode.Locked;

        StartCoroutine(BlackScreenDown(1));
        StartCoroutine(FadeScreenDown(1.99F));
        
    }
    IEnumerator BlackScreenDown(float time)
    {
        yield return new WaitForSeconds(time);
        FadeScreen.GetComponent<Animator>().enabled = true;
        BlackScreen.SetActive(false);
    }

    IEnumerator FadeScreenDown(float time)
    {
        yield return new WaitForSeconds(time);
        FadeScreen.GetComponent<Animator>().enabled = false;
        FadeScreen.SetActive(false);
    }
    
}
