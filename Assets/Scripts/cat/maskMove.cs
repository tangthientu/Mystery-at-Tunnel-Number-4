using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maskMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody m_Rigidbody;
    public float m_Speed ;
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
}
