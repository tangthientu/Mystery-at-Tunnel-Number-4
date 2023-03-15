using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class angel2 : MonoBehaviour
{
    public Transform playerObj;
    public Transform enemy;
    protected NavMeshAgent enemyMesh;



    // Start is called before the first frame update

    void Start()
    {
        enemyMesh = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        enemyMesh.SetDestination(playerObj.position);
        

    }
   
}