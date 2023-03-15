using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSoundsManager : MonoBehaviour
{
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source =this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PauseMenu.GameIsPaused == true)
        {
            source.Pause();
        }
        else
        {
            source.UnPause();
        }    
    }
}
