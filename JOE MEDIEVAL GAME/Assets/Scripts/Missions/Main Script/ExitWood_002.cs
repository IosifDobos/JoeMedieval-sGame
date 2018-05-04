using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitWood_002 : MonoBehaviour {
    public GameObject textBox;
    public GameObject playerText;
    public GameObject questStatus;

    // Use this for initialization
    private IEnumerator OnTriggerEnter(Collider other)
    {
        transform.position = new Vector3(0, -1000, 0);
        textBox.SetActive(true);
        playerText.SetActive(true);
        playerText.GetComponent<Text>().text = "Looks like a village over that bridge!";
        yield return new WaitForSeconds(3f);
        playerText.GetComponent<Text>().text = "";
        textBox.SetActive(false);
        yield return new WaitForSeconds(3f);
        textBox.SetActive(true);
        playerText.GetComponent<Text>().text = "I should check it out";
        yield return new WaitForSeconds(3f);
        playerText.GetComponent<Text>().text = "";
        textBox.SetActive(false);
        playerText.SetActive(false);
        questStatus.GetComponent<Text>().text = "Active Quest: Reach The Village";
        this.gameObject.SetActive(false);
    }
}
