using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest_001_Active : MonoBehaviour {

    public int TextBoxOnCheck = 0;
    public GameObject MessageBox;
    public GameObject TextBox;

    public GameObject QuestItemToClose;
    public GameObject QuestItemToShow;

    void OnMouseDown()
    {
        if (TextBoxOnCheck == 0)
        {
            TextBoxOnCheck = 1;
            MessageBox.SetActive(true);
            TextBox.GetComponent<Text>().text = "You found the loot bag.";
            StartCoroutine(CarryOn());
            
        }
    }

    IEnumerator CarryOn()
    {
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
        MessageBox.SetActive(false);
        QuestItemToClose.SetActive(false);
        QuestItemToShow.SetActive(true);
    }//close Ienumerator()
}
