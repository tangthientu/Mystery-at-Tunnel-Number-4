using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPlayer : MonoBehaviour
    
{
    public GameObject TBCscreen;
    public AudioSource voiceline;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void pausePlayer ()
    {
        Gun.allowedToShoot = false;
    }
    void TBC()
    {
        TBCscreen.SetActive(true);

    }
    void playhazmatsound()
    {
        voiceline.Play();
    }
}
