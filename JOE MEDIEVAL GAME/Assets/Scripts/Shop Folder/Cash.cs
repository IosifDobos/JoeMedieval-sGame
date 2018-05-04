using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cash : MonoBehaviour {

    public static int Coins = 100;
    public int LocalCoins;

    public GameObject CoinsDisplay;
    public GameObject ShopDisplay;
	
	// Update is called once per frame
	void Update () {
        LocalCoins = Coins;
        CoinsDisplay.GetComponent<Text>().text = "Coins: " + LocalCoins;
        ShopDisplay.GetComponent<Text>().text = "Coins: " + LocalCoins;
    }
}
