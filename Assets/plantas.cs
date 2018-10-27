using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantas : MonoBehaviour {

    public UIManager uiManager;

    void OnTriggerEnter2D(Collider2D other)
    {
        charactercustom Octopus = other.gameObject.GetComponent<charactercustom>();
        if (Octopus != null)
        {
            print("dead");
            uiManager.Die();
        }
    }
}
