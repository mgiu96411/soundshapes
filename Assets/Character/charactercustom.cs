using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercustom : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;// = 360f;
    public float jumpForce;//  = 500f;
    public bool jumpAllowed;

    public OctoAnim anim;


    void OnCollisionEnter2D(Collision2D col)
    {
        print(col.gameObject.tag);
        if (col.gameObject.tag.Equals("floor"))
        {
            jumpAllowed = true;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("floor"))
        { 
            jumpAllowed = false; 
        }
    }

    void Update()
    {

        float h = Input.GetAxis("Horizontal");

        if (h != 0)
        {
            //anim.Walk();
            rb.velocity = new Vector2(h * speed, rb.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && jumpAllowed == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
   
    }
    
}