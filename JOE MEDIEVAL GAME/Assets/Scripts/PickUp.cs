using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {

    public Transform Target;

    void Update()
    {

    }
    void OnMouseDown()
    {
        this.transform.position = Target.position;
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = GameObject.Find("FPSController").transform;
        this.transform.parent = null;
    }
}
