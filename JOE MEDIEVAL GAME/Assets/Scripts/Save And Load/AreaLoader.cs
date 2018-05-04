using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaLoader : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject StartScript;
    public GameObject VillageBox;
    public float PlayerX = 0.0f; //input player co-ordinates
    public float PlayerY = 0.0f; //input player co-ordinates
    public float PlayerZ = 0.0f; //input player co-ordinates
    public static string LoadCode;
    public GameObject QuestStatus;

    void Start()
    {
        //LoadCode = LoadGame.GlobalLoad;
        if (LoadCode == "savearea001")
        {
            ThePlayer.transform.position = new Vector3(PlayerX, PlayerY, PlayerZ);
            StartScript.SetActive(false);
            VillageBox.SetActive(false);
            QuestStatus.GetComponent<Text>().text = "Active Quest: Reach The Village";
        }
    }

}
