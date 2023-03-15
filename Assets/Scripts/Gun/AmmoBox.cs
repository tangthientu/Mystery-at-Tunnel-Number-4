using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AmmoBox : MonoBehaviour
{
    public GameObject inticon;
    public Gun gun;
   
    
    private UpdateMaxAmmo updateTotalAmmo;
    private void Start()
    {
        updateTotalAmmo = GameObject.Find("Canvas").GetComponent<UpdateMaxAmmo>();
        //gun = GameObject.Find("Gun").GetComponent<Gun>();
    }

    private void OnTriggerStay(Collider other)
    {
        
      if(gun != null)
        {
           
            if (other.CompareTag("MainCamera"))
            {
                inticon.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {
                    gun.maxAmmo++;
                    Destroy(this.gameObject);
                }


            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
       inticon.SetActive(false);
    }

}
