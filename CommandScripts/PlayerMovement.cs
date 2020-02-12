using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Command : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;  // Variable that determines the forward force
    public float sidewaysForce = 500f;  // Variable that determines the sideways force

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Command TurnLeft = new TurnLeft(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(TurnLeft);
            invoker.ExecuteCommand();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Command TurnRight = new TurnRight(rb, sidewaysForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(TurnRight);
            invoker.ExecuteCommand();
        }
    }
}
