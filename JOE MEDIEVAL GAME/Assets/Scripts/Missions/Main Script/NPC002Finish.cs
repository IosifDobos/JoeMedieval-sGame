using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC002Finish : MonoBehaviour
{
    public int TextBoxOnCheck = 0;

    public GameObject MessageBox;
    public GameObject TextBox;
    public GameObject MissionBox;
    public GameObject MissionText;

    public GameObject GoldBar;
  


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
            TextBox.GetComponent<Text>().text = "Servant: Thank you very much!";
            MissionText.GetComponent<Text>().text = "Active Quest: Explore";
            GoldBar.SetActive(false);
 

        }
        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
        }

    }
}
