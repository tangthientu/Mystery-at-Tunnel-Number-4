using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscareend : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource sound;
    public float time;
    void Start()
    {
        Invoke("playsound", time);

    }

    // Update is called once per frame
    void Update()
    {
      
    }


    void playsound()
    {
        sound.Play();
    }
}
