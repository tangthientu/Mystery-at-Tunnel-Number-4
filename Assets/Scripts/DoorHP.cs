using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHP : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 1f;
    
    public GameObject spawnTrigger;
    public AudioSource hitsound;
    public Animator animator;
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (hitsound != null)
        {


            hitsound.Play();

        }
        if (health <= 0)
        {
            Debug.Log("doordie");
            animator.SetBool("DoorOpen", true);
          
        }
    }
}
