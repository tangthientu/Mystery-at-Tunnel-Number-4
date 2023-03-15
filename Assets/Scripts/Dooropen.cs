using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dooropen : MonoBehaviour
{

    public Animator doorlid;
    public GameObject inticon;
    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("MainCamera"))
        {
            inticon.SetActive(true);
            if (Input.GetKey("e"))
            {
                doorlid.SetBool("OpenDoor", true);
                inticon.SetActive(false);
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inticon.SetActive(false);
            Invoke("setdoorclose",2f);
        }
    }
    void setdoorclose()
    {
        doorlid.SetBool("OpenDoor", false);
    }
}
