using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
         player= GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public PlayerHP HP;
    void attacktarget()
    {

        GameObject.Find("Player").GetComponent<PlayerHP>().TakeDamage(20);



    }
}
