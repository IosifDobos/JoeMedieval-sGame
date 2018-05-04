using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC002Start : MonoBehaviour
{
    public int TextBoxOnCheck = 0;

    public GameObject MessageBox;
    public GameObject TextBox;
    public GameObject MissionBox;
    public GameObject MissionText;

    public GameObject Key;
    public GameObject CaveDoor;


	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Submit"))
        {

            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {

            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
            }
        }
    }

    void OnMouseDown()
    {
        if(TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "Servant: Somewhere on the mountains is a cave and there you can find some gold. Can you go there and find the gold for me!!!";
            MissionText.GetComponent<Text>().text = "Active Quest: Find the cave and get the gold";
            Key.SetActive(true);
            CaveDoor.SetActive(true);

        }
        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
        }

    }
}
