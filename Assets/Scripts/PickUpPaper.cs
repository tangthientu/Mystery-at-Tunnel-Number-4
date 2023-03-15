using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPaper : MonoBehaviour
{
    public GameObject ppground, ppshow, inticon;
    public AudioSource pickup;
    public bool papershowing=false;
    public bool havepp;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&havepp)
        {
            Debug.Log("presskey ");
            {
                if (papershowing == true)
                {
                    showpp();
                }
                else
                    hidepp();
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("PlayerSight"))
        {
            inticon.SetActive(true);
            havepp = true;
         
        }

            
                 
                    
            
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerSight"))
        {
            inticon.SetActive(false);
           hidepp();
            havepp = false;
        }

    }
    void showpp()
    {
        inticon.SetActive(false);
        ppshow.SetActive(true);
        pickup.Play();
        papershowing = false;
    }
    void hidepp()
    {
        ppshow.SetActive(false);
        papershowing = true;
    }
}
