using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatOFF : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject flight,cat,catwarn,catend,catvoice,catrun,breath;
    

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            
            flight.SetActive(false);
            if (cat != null)
            {
                cat.SetActive(false);
            }
            catwarn.SetActive(false);
                catvoice.SetActive(false);
            Destroy(catrun);
            Destroy(breath);
            catend.SetActive(true);
            
           
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            
        }
    }

}
