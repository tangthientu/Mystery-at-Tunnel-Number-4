using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Zombie;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Zombie.SetActive(true);
            gameObject.SetActive(false);
        }
        
    }
}
