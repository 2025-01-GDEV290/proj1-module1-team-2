using UnityEngine;

public class DoorControl : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;

    public AudioClip Crash;
    private bool CrashSoundPlaying;
    private AudioSource src;
    private void Start()
    {
        src = GetComponent<AudioSource>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            void playCrash()
            {
                if (CrashSoundPlaying == false)
                {
                    CrashSoundPlaying = true;
                    src.clip = Crash;
                    src.Play();
                }
            }

            void stopCrash()
            {
                if (CrashSoundPlaying == true)
                {
                    CrashSoundPlaying = false;
                    src.Stop();
                    src.clip = null;
                }
            }
            if (openTrigger)
            {
                myDoor.Play("Gate left open", 0, 0.0f);
                myDoor.Play("Gate Right Open", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }
}

