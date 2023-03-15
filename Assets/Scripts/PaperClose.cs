using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperClose : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject paper;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (paper.active)
        {


            if (Input.GetKey(KeyCode.Escape))
            {
                paper.SetActive(false);
            }

        }
    }
   
}
