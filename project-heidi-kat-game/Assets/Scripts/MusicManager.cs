using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    public AudioSource audioSrc;

    [SerializeField]
    public AudioClip opener = null;

    [SerializeField]
    public AudioClip ambientSpaceship = null;

    [SerializeField]
    public AudioClip ambienttunnels = null;

    [SerializeField]
    public AudioClip creepy = null;

    [SerializeField]
    public AudioClip combat1 = null;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void HandleMusic(string music)
    {
        bool noPlay = false;
        Debug.Log("MusicPlay Called");
        switch(music)
        {
            case "opener":
                audioSrc.clip = opener;
                break;
            case "ambient spaceship 1":
                audioSrc.clip = ambientSpaceship;
                break;
            case "ambient tunnels 1":
                audioSrc.clip = ambienttunnels;
                break;
            case "creppy":
                audioSrc.clip = creepy;
                break;
            case "combat1":
                audioSrc.clip = combat1;
                break;
            case "music fade":
                audioSrc.Stop();
                break;
            default:
                noPlay = true;
                Debug.Log("Unknown Music Command: " + music);
                break;

        }
        if (!noPlay)
            audioSrc.Play();
        noPlay = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
