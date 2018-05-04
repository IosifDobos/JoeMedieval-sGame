using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest_001 : MonoBehaviour {

    public GameObject QuestUpdate;
    public GameObject TextDisplay;

    public GameObject PlayerText;

    public int Timecounter = 0;
    public int TextBoxOnCheck = 0;

	// Use this for initialization
	void Start () {
        QuestBegin();	
	}
	
    void QuestBegin()
    {
        this.transform.position = new Vector3(0, -1000, 0);
        QuestUpdate.GetComponent<Text>().text = "Active Quest: Exit the Woods";

        if(Timecounter == 0)
        {
            StartCoroutine(Timer(3f));
        }

        if(Timecounter == 1)
        {
            TextDisplay.SetActive(true);
            PlayerText.GetComponent<Text>().text = "Where am I?";
            StartCoroutine(Timer(time: 1f));
        }

        if (Timecounter == 2)
        {
            PlayerText.GetComponent<Text>().text = "I need to find a way out of the forest";
            StartCoroutine(Timer(time: 2f));
        }

        if (Timecounter == 3)
        {
            PlayerText.GetComponent<Text>().text = "First mission try to get out of the forest";
            StartCoroutine(Timer(time: 2f));
        }

        if (Timecounter == 4)
        {
            PlayerText.GetComponent<Text>().text = "";
            TextDisplay.SetActive(false);
            gameObject.SetActive(false);
            //StartCoroutine(Timer(time: 3f));
        }

    }//end QuestBegin function

    //private void NewMethod()
    //{
    //    StartCoroutine(Timer(time: 3f));
    //}

    IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        Timecounter += 1;
        QuestBegin();
    }//close Ienumerator()

}//close main class
