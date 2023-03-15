using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatON : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flight;
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            flight.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            
        }
    }

}
