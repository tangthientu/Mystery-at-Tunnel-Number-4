using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public GameObject Trigger;
    public GameObject light;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PlayerSight"))
        {
            animator.SetBool("ActiveJC", true);
            Debug.Log("activatedjc");
            Trigger.SetActive(false);
            Invoke("lightoff", 1f);
        }
    }
    void lightoff()
    {
        light.SetActive(false);
    }
}
