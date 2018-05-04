using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour {

    public int hitpoints = 10;
    public float totargert;
    public float range = 150.0f;

    void Update()
    {
        if (Input.GetButtonDown("Hit"))
        {
            RaycastHit hit;// = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
            {
                totargert = hit.distance;
                if (totargert < range)
                {
                    hit.transform.SendMessage("DeductPoints", hitpoints, SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
