using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static AudioClip snatcherSound, mouseClickSound;
    static AudioSource audioSrc;
    void Start()
    {
        snatcherSound = Resources.Load<AudioClip>("body_snatcher_sound");
        mouseClickSound = Resources.Load<AudioClip>("mouse_click_sound");

        audioSrc = GetComponent<AudioSource> ();
     	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
    	switch (clip)
    	{
    		case "body_snatcher_sound":
	    		audioSrc.PlayOneShot (snatcherSound);
	    		break;
	    	case "mouse_click":
	    		audioSrc.PlayOneShot (mouseClickSound);
	    		break;


    	}
    }
}
