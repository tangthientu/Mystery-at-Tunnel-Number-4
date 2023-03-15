using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Transform destination;
    void OnTriggerEnter(Collider other)
    {
        player.transform.position = destination.transform.position;
        
    }
}
