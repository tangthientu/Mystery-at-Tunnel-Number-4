using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorspawnzombie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Target target;
    // Update is called once per frame
    void Update()
    {
        target.health = 0;
    }
}
