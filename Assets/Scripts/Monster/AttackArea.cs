using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerHP PlayerHP;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Playergrab"))
        {
            attacktarget();
        }
        
    }
    void attacktarget()
    {

        PlayerHP.TakeDamage(20);



    }
    
}
