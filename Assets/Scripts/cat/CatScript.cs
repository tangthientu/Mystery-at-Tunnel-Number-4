using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScript : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public GameObject sound;
    public GameObject sound2;
    public GameObject flight;
    public GameObject subtrigger;
    public static bool flon;
    Animation flicker;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            InvokeRepeating("flashrepeat", 2f, 0.5f);
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        
    }
    void flashrepeat()
    {
        flight.SetActive(false);
        Debug.Log("ok");
        flon = false;
        Debug.Log("ko");
        if (flon == false)
        {
            flight.SetActive(true);
        }
    }
}
