using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElavatorButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject buttonIcon;
    public Animator animator;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerSight"))
        {
            buttonIcon.SetActive(true);
            
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
                buttonIcon.SetActive(false);
                animator.SetBool("ActiveElavator", true);

            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        buttonIcon.SetActive(false);
    }
}
