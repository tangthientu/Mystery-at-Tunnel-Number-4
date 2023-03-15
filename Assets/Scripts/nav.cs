using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class nav : MonoBehaviour
{
    public Transform playerObj;
    
    protected NavMeshAgent enemyMesh;
    public static bool moveable=true;
    public Attack ascript;
    public Target target;


    // Start is called before the first frame update

    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
        playerObj = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (moveable)
        {
            enemyMesh.isStopped = false;
            enemyMesh.SetDestination(playerObj.position);
        }
        else
            enemyMesh.isStopped = true;

      if(target.health<0)
        {
            moveable = false;
           
            

        }
       
    }
    void resumemove()
    {
        moveable = true;

    }
    void pausemove()
    {
        moveable = false;
    }
}