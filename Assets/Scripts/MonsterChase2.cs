using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterChase2 : MonoBehaviour
{
    public Transform target;
    public Transform monster;

    public float speed = 4f;
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        

    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sight"))
        {
            rig.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sight"))
        {
            rig.constraints = RigidbodyConstraints.None;
        }
    }
}
