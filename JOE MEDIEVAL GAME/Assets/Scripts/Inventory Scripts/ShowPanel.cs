using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanel : MonoBehaviour {

    public GameObject InfoPanel;

    public void OpenPanel()
    {
        InfoPanel.SetActive(true);
    }
}
