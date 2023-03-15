using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookatplayer2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform mLookAt;
    private Transform localTrans;
    void Start()
    {
        localTrans = GetComponent<Transform>();
       mLookAt= GameObject.Find("Head").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mLookAt)
        {
            localTrans.LookAt(2*localTrans.position-mLookAt.position);
        }
    }
}
