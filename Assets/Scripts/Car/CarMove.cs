using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody m_Rigidbody;
    public float m_Speed ;
    public float m_MinSpeed;
    public bool isDecreasingDone = false;
    public GameObject car,inticon;
    public GameObject player;
    public GameObject UI;
    public GameObject CarEvent;



    void Start()
    {
       
        m_Rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
     

    }

    // Update is called once per frame
    void Update()
    {
        m_Rigidbody.velocity = transform.forward * m_Speed;
    }
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Car"))
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
        if (other.CompareTag("Car1"))
        {
            m_Speed = 0;
            inticon.SetActive(true);
            Invoke("switchcam", 3);

        }
    }
    void switchcam()
    {
        car.SetActive(false);
        player.SetActive(true);
        inticon.SetActive(false);
        UI.SetActive(true);
        Destroy(CarEvent);
    }
}
