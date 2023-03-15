using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolPickUp : MonoBehaviour
{
    public GameObject Gun;
    public GameObject SpawnTrigger;
    public GameObject GunPlayer;
    public GameObject Instruction;
    public Animator animator;
    public AudioSource equipsound;
    public GameObject UI;
    public GameObject initicon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("PlayerSight"))
        {
            initicon.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {

                equipsound.Play();
                Gun.SetActive(false);
                GunPlayer.SetActive(true);
                initicon.SetActive(false);
                Instruction.SetActive(true);
                UI.SetActive(true);
                Invoke("InstructionClose", 5f);
                if (SpawnTrigger != null)
                {
                    SpawnTrigger.SetActive(true);
                }
                Destroy(initicon);
                gameObject.SetActive(false);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        initicon.SetActive(false);
    }
    public void InstructionClose()
    {
        Instruction.SetActive(false);

    }    
}
