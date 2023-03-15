using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Start is called before the first frame update
    public int spinSpeed=400;
    void Start()
    {
       
    }
    private void Update()
    {
        transform.Rotate(0f, 400 * Time.deltaTime, 0f, Space.Self);
    }
}
