using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

	public void StartButton ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("programacion");
    }

	void Update ()
    {
        if (Input.GetButtonDown("restart"))
        UnityEngine.SceneManagement.SceneManager.LoadScene("programacion");
    }

    public void Die ()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("programacion");
    }
}
