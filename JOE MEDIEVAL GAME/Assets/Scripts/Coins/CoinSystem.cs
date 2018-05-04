using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSystem : MonoBehaviour {

    public static int coinsCollect = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 100, 50), ("Coins: " + coinsCollect));
    }
}
