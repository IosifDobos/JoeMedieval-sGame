using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest002Gold : MonoBehaviour {

    public GameObject Gold;
    public GameObject GoldImg;
    public GameObject ThisObject;
    public GameObject QuestEnd;

    private void OnMouseDown()
    {
        ThisObject.GetComponent<BoxCollider>().enabled = false;
        GoldImg.SetActive(true);
        Gold.SetActive(false);
        QuestEnd.SetActive(true);
        ThisObject.SetActive(false);
    }

}
