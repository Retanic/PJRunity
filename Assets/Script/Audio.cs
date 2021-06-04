using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static AudioClip Audiogra;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        Audiogra = Resources.Load<AudioClip>("gra");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Playsound (string clip)
    {
        switch (clip)
        {
            case "gra":
                audioSrc.PlayOneShot (Audiogra);
                break;
        }
    }
}
