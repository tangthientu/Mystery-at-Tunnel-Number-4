using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject thisScene;
    public GameObject nextScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
             Destroy(thisScene);
                    nextScene.SetActive(true);
        }
       
        
    }
}
