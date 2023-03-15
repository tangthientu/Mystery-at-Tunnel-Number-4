using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public AudioSource audio;
    public AudioSource audio2;
    public AudioSource audio3;
    void PlayTheAudio()
    {
        audio.Play();
    }
    void PlayTheAudio2()
    {
        audio2.Play();
    }
    void PlayTheAudio3()
    {
        audio3.Play();
    }
}
