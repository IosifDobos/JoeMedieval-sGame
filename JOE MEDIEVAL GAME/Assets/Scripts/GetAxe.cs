using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAxe : PlayerCasting
{

    //declare variables
    public float distance = DistanceFromTarget;
    public GameObject TextDisplay;
    public GameObject FakeAxe;
    public GameObject RealAxe;
	
	// Update is called once per frame
	void Update () {
        distance = DistanceFromTarget;
	}

    private void OnMouseOver()
    {
        if(distance <= 200)
        {
            TextDisplay.GetComponent<Text>().text = "Take the Axe";
        }
    }

    private void OnMouseExit()
    {
        TextDisplay.GetComponent<Text>().text = "";
    }

    private void OnMouseDown()
    {
        if(distance <= 200)
        {
            transform.position = new Vector3(0, -1000, 0);
            RealAxe.SetActive(true);
            FakeAxe.SetActive(false);
        }

    }
}
