using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC002Idle : MonoBehaviour {

    public int TextBoxOnCheck = 0;
    public string MissionName;

    public GameObject MessageBox;
    public GameObject TextBox;




    // Update is called once per frame
    void Update()
    {
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

    private void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {

            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "Servant: Sorry I am busy at the moment. Come back later on!!!";

        }
        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
           // TextMessage = "Villager: Get Going then!";
        }
    }
}
