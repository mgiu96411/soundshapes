using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class Events
{

    public static System.Action<string> OnSoundFX = delegate { };
    public static System.Action<string, float> OnMusicOn = delegate { };
    public static System.Action<string, float> OnChar = delegate { };
    //public static System.Action<string> OnMusicOn = delegate { };
    //public static System.Action<string> <float> OnMusicOn = delegate { };

}

//void OnSoundFX(string audioName, float volume)



//int totalMusSounds = 4;



//SoundManager.OnChar(string, float)'