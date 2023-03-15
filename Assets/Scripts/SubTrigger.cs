using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sound;
    public GameObject inticon;
        public GameObject subtrigger;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (inticon != null)
            {
                inticon.SetActive(true);
            }
            
            if (sound != null)
            {
                sound.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
            Object.Destroy(subtrigger);
        }
    }
}
