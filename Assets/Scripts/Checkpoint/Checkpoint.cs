using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 CheckPoint;
    public Vector3 lcplocation;
    public GameObject LatestCheckPoint;
    void Start()
    {
        CheckPoint = gameObject.transform.position;
        LatestCheckPoint = GameObject.Find("LatestCheckPoint");
        
        setCheckPoint();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            setCheckPoint();
        }
    }
    void setCheckPoint()
    {
        LatestCheckPoint.transform.position = CheckPoint;
        Debug.Log("set new checkpoint");
    }
}
