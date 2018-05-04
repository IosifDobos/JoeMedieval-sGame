using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest_001_End : MonoBehaviour {

    public int TextBoxOnCheck = 0;
    //public string MissionName;

    public GameObject MissionBox;
    public GameObject MissionText;
    public GameObject MessageBox;
    public GameObject TextBox;

    public GameObject NPC002Idle;
    public GameObject NPC002Start;




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
            TextBox.GetComponent<Text>().text = "Thank you. You can speak with the servant for more missions";
            MissionText.GetComponent<Text>().text = "Active Quest : Got to servant for more missions";
            NPC002Idle.SetActive(false);
            NPC002Start.SetActive(true);
        }
        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
           
        }
    }
}
