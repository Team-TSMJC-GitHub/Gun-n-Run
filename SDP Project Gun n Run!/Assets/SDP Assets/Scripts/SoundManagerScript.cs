using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip jumpSound;
    static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

        jumpSound = Resources.Load<AudioClip>("Kid saying Hello Motherfucker");
        

        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Kid saying Hello Motherfucker":
                audioSrc.PlayOneShot(jumpSound);
                break;
            
        }
    }
}
