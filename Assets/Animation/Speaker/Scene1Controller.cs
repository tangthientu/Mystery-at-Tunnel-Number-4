using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem Smoke;
    public GameObject scene1;
    public GameObject scene2;
    public GameObject blackScreen;
    public GameObject Light;
    void Start()
    {
        RenderSettings.fog = false;
        PlayerController.AllowedToJump = true;
        NotAllowedToLoad.allowLoading = false;
        if(blackScreen = null)
        {
            blackScreen.SetActive(true);
        }
        if(Light!=null)
        {
            Light.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void activeSmoke()
    {
        Smoke.Play();
    }
    void switchScene2()
    {
        PlayerController.canMove = true;
        scene1.SetActive(false);
        scene2.SetActive(true);
    }
}
