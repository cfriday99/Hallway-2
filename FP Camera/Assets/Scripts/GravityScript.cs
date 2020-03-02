using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{

    public CharacterController characterController;
    public float gravityAmount;

    private bool grounded;

    private void Update()
    {
        if (!grounded)
        {
            characterController.Move(new Vector3(0.0f, -gravityAmount, 0.0f));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }

}
