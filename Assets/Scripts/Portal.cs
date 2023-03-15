using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    // Start is called before the first frame update
   
    public static bool keyfound1;
    public static bool keyfound2;
    public GameObject door;
    
    void Start()
    {
        keyfound1 = false;
        keyfound2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyfound1 == false && keyfound2 == false)
        {
            door.SetActive(false);
        }
        if (keyfound1 == true && keyfound2 == true)
        {
            door.SetActive(true);
        }
    }
}
