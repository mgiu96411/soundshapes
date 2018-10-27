using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicTrigger : MonoBehaviour {

	//public UIManager uiManager;

    //float volume = .5f
 
	void OnTriggerEnter2D(Collider2D other)
	{
        charactercustom character = other.gameObject.GetComponent<charactercustom> ();
		if (character != null) {
            //character.Die ();
            //uiManager.Lose ();
            Events.OnMusicOn("mus", .5f);

            Destroy(this.gameObject);

        }
    }
}
    