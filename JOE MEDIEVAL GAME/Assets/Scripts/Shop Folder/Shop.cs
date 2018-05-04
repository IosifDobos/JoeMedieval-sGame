using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour{

    public static string Item01;
    public static string Item02;
    public static string Item03;
    public static string Item04;

    public static int Item01Price;
    public static int Item02Price;
    public static int Item03Price;
    public static int Item04Price;

    public static int ShopNo;

    // Update is called once per frame
    void Update () {
		if(ShopNo == 1)
        {
            Item01 = "Iron Sword";
            Item01Price = 35;
            Item02 = "Gold Sword";
            Item02Price = 50;
            Item03 = "Axe Hammer";
            Item03Price = 25;
            Item04 = "Ice Sword";
            Item04Price = 30;
        }

        if (ShopNo == 2)
        {
            Item01 = "Iron Block";
            Item02 = "Black Feather";
            Item03 = "Red Potion";
            Item04 = "";
        }
    }
}
