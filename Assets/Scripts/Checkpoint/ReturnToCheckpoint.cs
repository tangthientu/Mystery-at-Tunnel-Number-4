using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToCheckpoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PlayerLocation;
    public Checkpoint checkpoint;
    public PlayerHP playerHP;
    void Start()
    {
        PlayerLocation = GameObject.Find("Player");
       
        playerHP = gameObject.GetComponent<PlayerHP>();
    }

    // Update is called once per frame
    
    void Update()
    {
        if(Input.anyKeyDown)
        {
            playerHP.CurrentHP = playerHP.MaxHP;
        
        }
    }
}
