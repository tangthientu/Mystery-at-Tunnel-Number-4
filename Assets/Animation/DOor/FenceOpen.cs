using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SaveIsEasy;
[RequireComponent(typeof(SaveIsEasyComponent))]

public class FenceOpen : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    [QuickAccess]
    public static bool fenceKeyFound = false;
    public int fencecheck=0;
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        

    }
    private void OnTriggerStay(Collider other)
    {
      
        if(other.CompareTag("PlayerSight"))
        {
            
                if (Input.GetKey(KeyCode.E)&& fencecheck==1)
                {
                    Debug.Log("open");
                animator.SetBool("DoorOpen",true);
                
                Destroy(gameObject);
            }
            
            
        }
    }
    
}
