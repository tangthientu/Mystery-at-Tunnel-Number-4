using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameoverText : MonoBehaviour
{
    public float timeRemaining;
    public GameObject text;
    public GameObject text2;
    public AudioSource sound;
    public string scene="MainMenu";
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            text.SetActive(true);
            text2.SetActive(true);
            
            if (Input.anyKey)
            {
                SceneManager.LoadScene(scene);
            }
        }
       

    }
    
}