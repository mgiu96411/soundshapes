using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pbl_charactercustom : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rb;
    public float speed;// = 360f;
    public float maxSpeed;//  = 5f;
    public float jumpForce;//  = 500f;
    public float jumpSecondFactor;//  = 250f;
    bool jump;
    public bool grounded;
    public Transform groundCheck;
    public int jumps;

    float lastTimeOnFloor;

    private void Start()
    {
       anim = GetComponent<Animator>();
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(h * speed, rb.velocity.y);
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Floor"));
        if (Time.time > lastTimeOnFloor + 0.2f && grounded)
            jumps = 0;
        if (Input.GetButtonDown("Jump") && grounded == true && jumps == 0)
        {
            lastTimeOnFloor = Time.time;
            rb.AddForce(new Vector2(0f, jumpForce));
            jumps = 1;
            anim.SetBool("jump", true);
        }
        else if (Input.GetButtonDown("Jump") && jumps == 1)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
            rb.AddForce(new Vector2(0f, jumpForce * jumpSecondFactor));
            jumps = 2;
            anim.SetBool("jump", true);
        }
        else if(jumps == 2)
        {
            anim.SetBool("jump", false);
        }
        if (h < 0)
            //transform.localScale = new Vector3(-this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
            transform.localScale = new Vector3(-0.25f, 0.25f, 0.25f);
            
        
        else if (h > 0)
            //transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, this.transform.localScale.z);
            transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);

        if (Mathf.Abs(h) > 0)
        {
            anim.SetFloat("walk", Mathf.Abs(h));
        }
        else
        {
            anim.SetFloat("walk", Mathf.Abs(h));
        }
        //Debug.Log(h);
    }
    
}