using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catjumpscare : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject catmask;
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            catmask.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            
        }
    }
}
