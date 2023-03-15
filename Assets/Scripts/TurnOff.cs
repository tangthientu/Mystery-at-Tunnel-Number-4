using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Thing;
    public GameObject Sub;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            Sub.SetActive(true);
            if (Input.GetKey("e"))
             {
                        Thing.Stop();
                Destroy(gameObject);
                Destroy(Sub);
                FenceOpen.fenceKeyFound = false;
            }
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            Sub.SetActive(false);
        }
    }
}
