using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    public GameObject ThePlayer;
    public GameObject OurInventory;
    public int InventoryStatus;

    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            ThePlayer.GetComponent<FirstPersonController>().enabled = false;
            //Screen.lockCursor(false);
            //Debug.Log(Cursor.lockState);
            Screen.lockCursor = false;
            Cursor.visible = true;
            if (InventoryStatus == 0)
            {
                InventoryStatus = 1;
                //Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                OurInventory.SetActive(true);
            }
            else
            {
                InventoryStatus = 0;
                //Cursor.lockState = CursorLockMode.Locked;
                ThePlayer.GetComponent<FirstPersonController>().enabled = true;
                Cursor.visible = false;
                OurInventory.SetActive(false);
            }
        }
    }
}
