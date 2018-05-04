using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Shop001Access : MonoBehaviour {

    public GameObject ShopInventory;
    public GameObject Item01Text;
    public GameObject Item02Text;
    public GameObject Item03Text;
    public GameObject Item04Text;
    public GameObject ItemCompletion;
    public GameObject CompleteText;

    public GameObject ThePlayer;
    public GameObject ShopPanel;

    public GameObject Item01PrixeBox;
    public GameObject Item02PrixeBox;
    public GameObject Item03PrixeBox;
    public GameObject Item04PrixeBox;

    public int ItemPurchaseNo;
    public GameObject NoMoney;

    private void OnMouseDown()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = false;
        ShopInventory.SetActive(true);
        //Debug.Log(Cursor.lockState);
        Screen.lockCursor = false;
        Cursor.visible = true;
        Shop.ShopNo = 1;
        Item01Text.GetComponent<Text>().text = "" + Shop.Item01;
        Item02Text.GetComponent<Text>().text = "" + Shop.Item02;
        Item03Text.GetComponent<Text>().text = "" + Shop.Item03;
        Item04Text.GetComponent<Text>().text = "" + Shop.Item04;

        Item01PrixeBox.GetComponent<Text>().text = "Price: " + Shop.Item01Price;
        Item02PrixeBox.GetComponent<Text>().text = "Price: " + Shop.Item02Price;
        Item03PrixeBox.GetComponent<Text>().text = "Price: " + Shop.Item03Price;
        Item04PrixeBox.GetComponent<Text>().text = "Price: " + Shop.Item04Price;
    }

    public void Item01()
    {
        ItemCompletion.SetActive(true);
        CompleteText.GetComponent<Text>().text = "Are you sure you want to buy " + Shop.Item01 + "?";
        ItemPurchaseNo = 1;
    }

    public void Item02()
    {
        ItemCompletion.SetActive(true);
        CompleteText.GetComponent<Text>().text = "Are you sure you want to buy " + Shop.Item02 + "?";
        ItemPurchaseNo = 2;
    }

    public void Item03()
    {
        ItemCompletion.SetActive(true);
        CompleteText.GetComponent<Text>().text = "Are you sure you want to buy " + Shop.Item03 + "?";
        ItemPurchaseNo = 3;
    }

    public void Item04()
    {
        ItemCompletion.SetActive(true);
        CompleteText.GetComponent<Text>().text = "Are you sure you want to buy " + Shop.Item04 + "?";
        ItemPurchaseNo = 4;
    }

    public void CancelTransaction()
    {
        ItemCompletion.SetActive(false);
        ItemPurchaseNo = 0;
        NoMoney.SetActive(false);
    }

    public void CompleteTransaction()
    {
        if(ItemPurchaseNo == 1)
        {
            if(Cash.Coins >= Shop.Item01Price)
            {
                Cash.Coins -= Shop.Item01Price;
                ItemCompletion.SetActive(false);
            }
            else
            {
                NoMoney.SetActive(true);
            }
        }

        if (ItemPurchaseNo == 2)
        {
            if (Cash.Coins >= Shop.Item02Price)
            {
                Cash.Coins -= Shop.Item02Price;
                ItemCompletion.SetActive(false);
            }
            else
            {
                NoMoney.SetActive(true);
            }
        }

        if (ItemPurchaseNo == 3)
        {
            if (Cash.Coins >= Shop.Item03Price)
            {
                Cash.Coins -= Shop.Item03Price;
                ItemCompletion.SetActive(false);
            }
            else
            {
                NoMoney.SetActive(true);
            }
        }

        if (ItemPurchaseNo == 4)
        {
            if (Cash.Coins >= Shop.Item04Price)
            {
                Cash.Coins -= Shop.Item04Price;
                ItemCompletion.SetActive(false);
            }
            else
            {
                NoMoney.SetActive(true);
            }
        }
    }
}
