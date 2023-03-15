using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterChase : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody monsRigid;
    public Transform monsTrans, playTrans;
    public int monSpeed;
    void FixedUpdate()
    {
        monsRigid.velocity = transform.forward * monSpeed * Time.deltaTime;
    }
    void Update()
    {
        monsTrans.LookAt(playTrans);
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            monsRigid.velocity = transform.forward * 0 * Time.deltaTime;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            monsRigid.velocity = transform.forward * monSpeed * Time.deltaTime;
        }
    }
}
