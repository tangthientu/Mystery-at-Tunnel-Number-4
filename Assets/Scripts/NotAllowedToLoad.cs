using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotAllowedToLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool allowLoading;
    public GameObject loadable;
    public GameObject notloadable;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(allowLoading)
        {
            loadable.SetActive(true);
            notloadable.SetActive(false);
        }
     else
        {
            loadable.SetActive(false);
            notloadable.SetActive(true);
        }
            
    }
    void allowLoad()
    {
        allowLoading = true;
    }
    void notAllowLoad()
    {
        allowLoading = false;
    }
}
