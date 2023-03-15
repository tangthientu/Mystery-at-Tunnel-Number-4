using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public float health=30f;
    public GameObject enemy;
    public GameObject target;
    public GameObject killtrigger;
    public AudioSource hitsound;
    public AudioSource deathsound;
    public static bool dielater;
    public void TakeDamage(float damage)
    {
        
        health -= damage;
        if(hitsound != null)
        {
            
            
                hitsound.Play();
            
        }
        if (health <= 0)
        {
            
            
            if (deathsound!=null)
            {
                deathsound.Play();
            }
            if(enemy != null)
            {
                enemy.GetComponent<Animator>().Play("death");
            }
           nav.moveable = false;
           if(killtrigger != null)
            {
                killtrigger.SetActive(false);
            }
          if(dielater)
            {
                Invoke("die", 10f);
            }
          else
            Invoke("die", 10f);
          
            
        }
    }
    public void die()
    {
        Destroy(target);
    }
    
}
