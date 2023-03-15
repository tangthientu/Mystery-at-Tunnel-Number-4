using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowedToMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AllowToMove()
    {
        PlayerController.canMove = true;
    }
    public void NotAllowToMove()
    {
        PlayerController.canMove = false;
    }
}
