using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance: MonoBehaviour
{
    public Transform Player;
    public GameObject enemy;
    public GameObject text;
    public float Distance_;
    public float Range;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = (Player.transform.position - transform.position).magnitude;

        if (Distance_ > Range)
        {
            Destroy(enemy);
            text.SetActive(true);
            Invoke("textoff", 3f);
        }
    }
    void textoff()
    {
        text.SetActive(false);
    }
}