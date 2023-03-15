using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Filter;
    void Start()
    {
        RenderSettings.fog = true;
        PlayerController.AllowedToJump = true;
        PlayerController.canMove = true;
        NotAllowedToLoad.allowLoading = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
