using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip bgm;
    public AudioClip slimeHit;
    public AudioClip robotHit;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void playHitSound(string attacker)
    {
        if(attacker == "Slime")
        {
            audioSource.PlayOneShot(slimeHit);
        }

        else if(attacker == "Robot")
        {
            audioSource.PlayOneShot(robotHit);
        }
    }
}
