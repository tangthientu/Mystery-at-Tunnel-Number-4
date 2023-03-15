using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flashlight_ground, inticon, flashlight_player;
    public AudioSource pickup;
   
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKey("e"))
            {
                flashlight_ground.SetActive(false);
                inticon.SetActive(false);
                flashlight_player.SetActive(true);
                pickup.Play();
                gameObject.SetActive(false);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
        }
    }
   
}
