using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//
using UnityEngine.Events;
//

public class SoundManager : MonoBehaviour
{

    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;
    public AudioSource source4;

    int id = 0;
    int totalCoinSounds = 2;
    //
    //float volume = .25f;
    int totalMusSounds = 4;

    //


    // subscribirse en "On enable"
    // dessubscribirse en "on Disable"

    void Start()
    {
        Events.OnSoundFX += OnSoundFX;
        Events.OnMusicOn += OnMusicOn;
        Events.OnChar += OnChar;
    }

    void OnDestroy()
    {
      
            Events.OnSoundFX -= OnSoundFX;
            Events.OnMusicOn -= OnMusicOn;
            Events.OnChar -= OnChar;

    }




void OnSoundFX(string audioName)
    {

        if (audioName == "star")
        {
            //id++;
            //if (id > totalCoinSounds)
            //id = 1;
            //print("star");
            audioName = "sounds/star";
            AudioSource source = gameObject.AddComponent<AudioSource>();
            AudioClip clip = Resources.Load(audioName) as AudioClip;
            source.clip = clip;
            source.volume = .5f;
            source.pitch = Random.Range( .95f, 1.2f);
            source.Play();
            Destroy(source, source.clip.length);
        }


         if (audioName == "coin")
        {

            id++;
            if (id > totalCoinSounds)
                id = 1;
            //print(id);
            audioName = "sounds/pu_" + id;
            AudioSource source = gameObject.AddComponent<AudioSource>();
            AudioClip clip = Resources.Load(audioName) as AudioClip;
            source.clip = clip;
            source.volume = .5f;
            //source.pitch = Mathf.Lerp( 1f, 1.4f, ((float)Random.Range (1, 20)/10) );
            source.Play();
            Destroy(source, source.clip.length);

        }

    
    }

    //
    void OnChar(string audioName, float volume = .025f)
        //void OnChar(string audioName)
    {
        if (audioName == "jump")
        {
            //id++;
            //if (id > totalCoinSounds)
            //id = 1;

            //print(audioName);
            //audioName = "sounds/jump_" + id;
            audioName = "sounds/jump";
            //volume = .25f;

            AudioSource source = gameObject.AddComponent<AudioSource>();
            AudioClip clip = Resources.Load(audioName) as AudioClip;
            source.clip = clip;
            source.volume = .15f;
            //source.pitch = Mathf.Lerp( 0.6f, 1.6f, ((float)Random.Range (1, 20)/10) );
            source.pitch = Random.Range (.7f, 2f);
            source.Play();
            Destroy(source, source.clip.length);

        }
    }

    


        void OnMusicOn(string audioName, float volume = .9f)
        //void OnMusicOn(string audioName)

        {
            if (audioName == "mus")
            {
            // ??? PORQUE ID ARRANCA EN 2? 
            // A VECS REPITE EL INDICE CON 2 OBJETOS DISTINTOS 

            id++;
            if (id > totalMusSounds)
            id = 1;


            //COMO HACER QUE EL INDICE 3 REPRODUZCA A OTRO VOLUMEN?
            //if (id = 3)
            //volume = .5f;
            print(audioName + id);
                audioName = "sounds/mus_" + id;
                //volume = .5f;

                //


                AudioSource source = gameObject.AddComponent<AudioSource>();
        AudioClip clip = Resources.Load(audioName) as AudioClip;
             source.clip = clip;
            source.volume = .75f;
                //source.pitch = Mathf.Lerp( 1f, 1.4f, ((float)Random.Range (1, 20)/10) );
                source.loop = true;
                source.Play();
                //Destroy(source, source.clip.length);

                //Destroy(this.gameObject);

            }
    }



    ////UN INTENTO PARA HACER QUE TODOS LOS ARCHIVOS ARRANQUEN JUNTOS  
    //// HACE PLAY SOLO DEL ULTIMO ARCHIVO , TOMA EL ULTIMO AUDIONAME Y SOLO EJECYTA LA RUTINA PARA ESE ARCHVO
    ////
    //void OnMusicOn(string audioName, float volume = .9f)
    ////void OnMusicOn(string audioName)

    //    {
    //        if (audioName == "mus")
    //        {

    //            //print(audioName + id);
    //            audioName = "sounds/mus_1";
    //        AudioSource source = gameObject.AddComponent<AudioSource>();
    //        AudioClip clip = Resources.Load("sounds/mus_1") as AudioClip;
    //        source.clip = clip;
    //        source.volume = .75f;
    //        source.loop = true;
    //        source.Play();

    //        audioName = "sounds/mus_2";
    //        AudioSource source2 = gameObject.AddComponent<AudioSource>();
    //        AudioClip clip2 = Resources.Load("sounds/mus_2") as AudioClip;
    //        source.clip = clip2;
    //        source.volume = .75f;
    //        source.loop = true;
    //        source.Play();

    //        audioName = "sounds/mus_3";
    //        AudioSource source3 = gameObject.AddComponent<AudioSource>();
    //        AudioClip clip3 = Resources.Load("sounds/mus_3") as AudioClip;
    //        source.clip = clip3;
    //        source.volume = .75f;
    //        source.loop = true;
    //        source.Play();
    //        print(audioName);

    //        audioName = "sounds/mus_4";
    //        AudioSource source4 = gameObject.AddComponent<AudioSource>();
    //        AudioClip clip4 = Resources.Load("sounds/mus_4") as AudioClip;
    //        source.clip = clip4;
    //        source.volume = .75f;
    //        source.loop = true;
    //        source.Play();
    //        print(audioName);

    //    }
    //}


}
