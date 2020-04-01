using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip jumpSound,voiceSound,gameoverSound;
    static AudioSource audioSrc;
    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        voiceSound = Resources.Load<AudioClip>("voice");
        gameoverSound = Resources.Load<AudioClip>("gameover");

        audioSrc = GetComponent<AudioSource>();

        
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public static void playSound(string clip)
    {

        switch (clip)
        {
            case "voice":
                audioSrc.PlayOneShot(voiceSound);
                break;

            case "jump":
                audioSrc.PlayOneShot(jumpSound);
                break;

            case "gameover":
                audioSrc.PlayOneShot(gameoverSound);
                break;
        }   
        
         
    
    }

    public static void muteSound(string clip)
    {
       audioSrc.mute = !audioSrc.mute ;
              
        }
    }

 
    
