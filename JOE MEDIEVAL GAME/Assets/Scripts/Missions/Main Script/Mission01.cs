using UnityEngine;
using UnityEngine.UI;




public class Mission01 : MonoBehaviour {

    public int TextBoxOnCheck = 0;
    public string TextMessage;
    public string MissionName;

    public GameObject MessageBox;
    public GameObject TextBox;
    public GameObject MissionBox;
    public GameObject MissionText;

    public GameObject QuestItemToShow;



	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Submit"))
        {

            if(TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
                //TextMessage = "Villager: Go and get my Money";
            }
        }

        if (Input.GetButtonDown("Cancel"))
        {

            if (TextBoxOnCheck == 1)
            {
                MessageBox.SetActive(false);
                TextBoxOnCheck = 0;
               // TextMessage = "Villager: Go and get my Money";
            }
        }
    }

    private void OnMouseDown()
    {
        if(TextBoxOnCheck == 0)
        {
            QuestItemToShow.SetActive(true);
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = TextMessage;
            MissionName = "Active Quest : 'Recover Will money'";
            MissionText.GetComponent<Text>().text = MissionName;
            
        }
        else
        {
            TextBoxOnCheck = 0;
            MessageBox.SetActive(false);
            TextMessage = "Villager: Get Going then!";
        }
    }
}
