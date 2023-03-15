using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerAttackArea : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject Target;
    public GameObject attackRange;
    public float AttackCooldownTime;
    public float AttackCooldownTimeMain;
    public Animator animator;
    public float distance;
    public static bool dead = false;
    public static bool MAttacking;

    void Start()
    {
        animator.SetBool("IsMoving", true);
    }

    // Update is called once per frame
    void Update()
    {
     //   FollowTarget();
     if(MAttacking)
        {
            animator.SetBool("IsAttack", true);
            animator.SetBool("IsMoving", false);
        }
        else
        {
            
            animator.SetBool("IsAttack", false);
            animator.SetBool("IsMoving", true);
        }


    }
    void FollowTarget()
    {
        distance = Vector3.Distance(Target.transform.position, this.transform.position);
        if (distance > 8 && dead == false)
        {

            animator.SetBool("IsAttack", false);
            animator.SetBool("IsMoving", true);

        }
        if (distance < 5.5)
        {


            animator.SetBool("IsAttack", true);
            animator.SetBool("IsMoving", false);

        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            MAttacking = true;
            Debug.Log("attking");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MAttacking = false;
            Debug.Log("moving");
        }
    }
    public void Move()
    {
        nav.moveable = true;
    }



}
