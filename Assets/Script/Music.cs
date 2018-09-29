using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    public AudioSource AudioSource;

    public AudioClip AudioClip1;
    public AudioClip AudioClip2;

    void Start()
    {
        AudioSource.clip = AudioClip1;
        AudioSource.Play();
    }

    void Update()
    {
        if (PlayerStats.Lives <= 0)
        {
                AudioSource.clip = AudioClip2;
                AudioSource.Play();          
        }
    }
}