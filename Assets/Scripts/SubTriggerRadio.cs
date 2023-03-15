using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubTriggerRadio : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sound;
    public GameObject sound2;
    public GameObject light;
    public GameObject subtrigger;
    public GameObject jcTrigger;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
           if(sound2 != null)
            {
                sound2.SetActive(false);
            }
            if (light != null)
            {
                light.SetActive(true);
            }
            
           
            
            if (sound != null)
            {
                sound.SetActive(true);
            }
            if(jcTrigger != null)
            {
                jcTrigger.SetActive(true);
            }
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
           
            Object.Destroy(subtrigger);
        }
    }
}
