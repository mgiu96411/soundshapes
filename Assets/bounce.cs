using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour {

    public float bounceForce;


    void OnTriggerEnter2D(Collider2D other)
    {
        charactercustom character = other.gameObject.GetComponent<charactercustom>();
        if (character != null)
        {
            character.GetComponent<Rigidbody2D>().AddForce(transform.up * bounceForce);
        }
    }
}
