using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInfo : MonoBehaviour {

    public GameObject Axe;
    public GameObject InfoPanel;

    public void EquipItem()
    {
        Axe.SetActive(true);
        InfoPanel.SetActive(false);
    }

    public void CancelItem()
    {
        InfoPanel.SetActive(false);
    }
}
