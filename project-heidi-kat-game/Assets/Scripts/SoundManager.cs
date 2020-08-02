using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    public AudioClip snatcherSound = null;

    [SerializeField]
    public AudioClip mouseClickSound = null;

    [SerializeField]
    static AudioSource audioSrc;
    void Start()
    {

        audioSrc = transform.GetComponent<AudioSource> ();
     	
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(string clip)
    {

    	switch (clip)
    	{
    		case "body_snatcher_sound":
                audioSrc.clip = snatcherSound;
	    		break;
	    	case "mouse_click":
	    		audioSrc.clip = mouseClickSound;
	    		break;
            

    	}

        audioSrc.Play();

    }
}
