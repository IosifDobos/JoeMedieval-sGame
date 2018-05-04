using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    public Transform TelportationTarget;

    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "TelePad")
        {
            this.transform.position = TelportationTarget.position;
        }
    }

}
