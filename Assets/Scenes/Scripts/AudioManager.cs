using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip idleSound;
    public AudioClip movingSound;
    
    private bool idleSoundPlaying = false;
    private bool movingSoundPlaying = false;
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
        if (idleSoundPlaying == true)
        {
            idleSoundPlaying = false;
            src.Stop();
            src.clip = null;
        }
    }

    public void playMovingSound()
    {
       if(movingSoundPlaying == false)
        {
            movingSoundPlaying = true;
            src.clip = movingSound;
            src.Play();
        }
    }

    public void stopMovingSound()
    {
        if (movingSoundPlaying == true)
        {
            movingSoundPlaying = false;
            src.Stop();
            src.clip = null;
        }
    }
}
