using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OctoAnim : MonoBehaviour {

    public Animator anim;
    public states state;
    public enum states
    {
        IDLE,
        WALKING,
        JUMP,
        REACH_FLOOR,
        DEAD
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Walk()
    {
        if (state == states.WALKING)
            return;
        state = states.WALKING;

        anim.Play("walk");
    }
    public void Idle()
    {
        if (state == states.IDLE || state == states.JUMP)
            return;
        state = states.IDLE;

        anim.Play("idle");
    }
    public void Jump()
    {
        if (state == states.JUMP)
            return;
        state = states.JUMP;

        anim.Play("jump");
        //Events.OnSoundFX("sounds/jump");
    }
}
