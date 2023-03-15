using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaskLoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject catevent;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void loadPlayer()
    {
        catevent.SetActive(false);
        player.SetActive(true);
    }
    void unloadPlayer()
    {
      
        player.SetActive(false);
    }
}
