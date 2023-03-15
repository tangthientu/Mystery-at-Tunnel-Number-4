using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class angel : MonoBehaviour
{
    private bool isGazingUpon;
    public Transform monster;
    public Transform playerObj;
    public Animator animator;
    protected NavMeshAgent enemyMesh;
    public nav nav;
    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        nav = GetComponent<nav>();
    }
    void Update()
    {
        
     
    }
    public void GazingUpon()
    {
        nav.moveable = false;
        animator.speed = 0;
            
    }

    public void NotGazingUpon()
    {
         nav.moveable = true;
        animator.speed = 1;
            
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerGaze"))
        {
            GazingUpon();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PlayerGaze"))
        {
            NotGazingUpon();
        }
    }
}
