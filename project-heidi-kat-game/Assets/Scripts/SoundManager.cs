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
    public AudioClip snatcherTheme2 = null;

    [SerializeField]
    public AudioClip boopbeepboop1 = null;

    [SerializeField]
    public AudioClip clatterandbang = null;

    [SerializeField]
    public AudioClip voltetscreech2 = null;

    [SerializeField]
    public AudioClip voltetscreech3 = null;

    [SerializeField]
    public AudioClip crash = null;

    [SerializeField]
    public AudioClip glassbreak = null;

    [SerializeField]
    public AudioClip pewpew = null;

    [SerializeField]
    public AudioClip chestburst = null;

    [SerializeField]
    public AudioClip woozy = null;

    [SerializeField]
    public AudioClip metalfootsteps = null;

    [SerializeField]
    public AudioClip rummage = null;

    [SerializeField]
    public AudioClip dragging = null;

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
    		case "body snatcher sound":
                audioSrc.clip = snatcherSound;
	    		break;
	    	case "mouse_click":
	    		audioSrc.clip = mouseClickSound;
	    		break;
            case "body snatcher theme 2":
                audioSrc.clip = snatcherTheme2;
                break;
            case "boopbeepboop 1":
                audioSrc.clip = boopbeepboop1;
                break;
            case "clatter and bang":
                audioSrc.clip = clatterandbang;
                break;
            case "voltet screech 2":
                audioSrc.clip = voltetscreech2;
                break;
            case "voltet screech 3":
                audioSrc.clip = voltetscreech3;
                break;
            case "crash":
                audioSrc.clip = crash;
                break;
            case "glass break":
                audioSrc.clip = glassbreak;
                break;
            case "chestburst":
                audioSrc.clip = chestburst;
                break;
            case "woozy":
                audioSrc.clip = woozy;
                break;
            case "metal footsteps":
                audioSrc.clip = metalfootsteps;
                break;
            case "rummage":
                audioSrc.clip = rummage;
                break;
            case "dragging":
                audioSrc.clip = dragging;
                break;
            case "none":
                audioSrc.clip = null;
                break;
            default:
                break;
        }

        audioSrc.Play();

    }
}
