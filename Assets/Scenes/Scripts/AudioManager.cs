using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip idleSound;
    public AudioClip movesound;
    
    private bool idleSoundPlaying = false;
    private AudioSource src;
    private void Start()
    {
        src = GetComponent<AudioSource>();
    }
    public void playIdleSound()
    {
        if (idleSoundPlaying == false)
        {
            idleSoundPlaying = true;
            src.clip = idleSound;
            src.Play();
        }
    }

    public void stopIdleSound()
    {
        idleSoundPlaying = false;
        src.Stop();
        src.clip = null;
    }
}
