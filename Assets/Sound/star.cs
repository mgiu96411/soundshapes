using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{

    charactercustom target;
    //public UIManager uiManager;


    void Update()
    {
        if (target == null)
            return;

        transform.localPosition = Vector3.Lerp(transform.localPosition, target.transform.localPosition, 0.1f);

    }
    bool ison;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (ison)
            return;
        charactercustom character = other.gameObject.GetComponent<charactercustom>();
        if (character != null)
        {
            ison = true;
            Events.OnSoundFX("star");
            //uiManager.GetCoin (); 
            target = character;
            Invoke("OnDestroy", 0.25f);
            //print("star");
        }
    }
    void OnDestroy()
    {

        Destroy(this.gameObject);
    }
}

