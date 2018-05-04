using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ExitShop : Shop001Access
{

    public void ExitShopMode()
    {
        ThePlayer.GetComponent<FirstPersonController>().enabled = true;
        ShopPanel.SetActive(false);
        NoMoney.SetActive(false);
    }
	
}
