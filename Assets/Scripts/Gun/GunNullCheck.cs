using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunNullCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gun;
    public GameObject ammo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(gun.active)
        {
            ammo.SetActive(true);
        }
    }
}
