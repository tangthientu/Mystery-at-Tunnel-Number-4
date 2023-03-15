using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStop : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float m_Speed;
  
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Car"))
        {
             m_Speed=0;
             m_Rigidbody.velocity = transform.forward * m_Speed;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Car"))
        {

        }
    }

}
