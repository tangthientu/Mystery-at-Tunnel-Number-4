using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GradualSlow : MonoBehaviour
{
    private Rigidbody m_Rigidbody;
    public float m_Speed;
    public float m_MinSpeed;
    public bool isDecreasingDone = false;
    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject

    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.forward * m_Speed;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("StopPoint"))
        {
          
            if (isDecreasingDone == false)
            {
                m_Speed = m_Speed - 0.08f;
            }

            if (m_Speed <= 0)
            {
                m_Speed = 0;

                isDecreasingDone = true;
            }


        }

    }
}