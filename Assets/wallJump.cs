using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallJump : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool WallJumpAllowedLeft;
    public bool WallJumpAllowedRight;
    public float WallJumpForceUp;

    void checkCollidingSide()
    {
        Transform Octopus = gameObject.GetComponent<Transform>();
        if (transform.position.x < Octopus.transform.position.x)
        {
            Debug.Log("Player is colliding on target's right side");
            WallJumpAllowedLeft = true;
        }
        else if (transform.position.x > Octopus.transform.position.x)
        {
            Debug.Log("Player is colliding on target's left side");
            WallJumpAllowedRight = true;
        }
        else
        {
            WallJumpAllowedLeft = false;
            WallJumpAllowedRight = false;
        }
    }

    void OnTriggerEnter2D(Collision2D other)
    {
        charactercustom Octopus = other.gameObject.GetComponent<charactercustom>();
        if (Octopus != null)
        {
            checkCollidingSide();
            if (Input.GetButtonDown("Jump") && WallJumpAllowedLeft == true)
            {
                rb.AddForce(new Vector2(100f, WallJumpForceUp));
            }

            if (Input.GetButtonDown("Jump") && WallJumpAllowedRight == true)
            {
                rb.AddForce(new Vector2(-100f, WallJumpForceUp));
            }
        }
    }

}
