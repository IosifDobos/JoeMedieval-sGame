using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CharacterControler : MonoBehaviour {
    private bool hasAxe = false;

    public bool canSwing = true;
    public bool isSwinging = false;
    public float swingTimer = 1;

    public CharacterController controller;
    //public GameObject PlayerGUI;
    // Use this for initialization
    void Start () {
        hasAxe = true;
        //controller = GameObject.FindGameObjectWithTag("FPSController").GetComponent(CharacterController);
        //playerGUI = GameObject.FindGameObjectWithTag("First Person Controller").GetComponent(PlayerGUI);

        //GameObject.FindGameObjectWithTag(tag: "First Person Controller").GetComponent<CharacterController>(); //as CharacterController; //I'm not shure if this is right but it's work perfect for me
       // GameObject.FindGameObjectWithTag(tag: "First Person Controller").GetComponent<PlayerGUI>() = PlayerGUI;// as PlayerGUI; //I'm not shure if this is right but it's work perfect for me

    }
	
	// Update is called once per frame
	void Update () {
        //If we aren't moving and if we aren't swinging, then we idle!

        if (controller.velocity.magnitude <= 0 && isSwinging == false)
        {
            GetComponent<Animation>().Play("Idle");
            GetComponent<Animation>()["Idle"].wrapMode = WrapMode.Loop;
            GetComponent<Animation>()["Idle"].speed = 0.2f;
        }

        //If we're holding shift and moving, then sprint!

        if (controller.velocity.magnitude > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animation>().Play("Sprint");
            GetComponent<Animation>()["Sprint"].wrapMode = WrapMode.Loop;
        }

        //WOODCUTTING SECTION
        if (hasAxe == true && canSwing == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Stamina reduction applied to the PlayerGUI script
                //playerGUI.staminaBarDisplay -= 0.1f;

                //Swinging animation
                GetComponent<Animation>().Play("Swing");
                GetComponent<Animation>()["Swing"].speed = 2f;
                isSwinging = true;
                canSwing = false;
            }
        }

        if (canSwing == false)
        {
            swingTimer -= Time.deltaTime;
        }

        if (swingTimer <= 0)
        {
            swingTimer = 1;
            canSwing = true;
            isSwinging = false;
        }
    }
}

/**
internal class PlayerUI
{
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}*/