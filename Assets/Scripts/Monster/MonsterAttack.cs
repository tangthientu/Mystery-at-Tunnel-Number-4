using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterAttack : MonoBehaviour
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
    
    void Start()
    {
        animator.SetBool("IsMoving", true);
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
      
    }
    void FollowTarget()
    {
        distance = Vector3.Distance(Target.transform.position,this.transform.position);
        if(distance > 8 && dead==false)
        {
            
            animator.SetBool("IsAttack", false);
            animator.SetBool("IsMoving", true);

        }
        if(distance < 5.5)
        {
           
            
            animator.SetBool("IsAttack", true);
            animator.SetBool("IsMoving", false);

        }

      




    }
    public void Move()
    {
        nav.moveable = true;
    }




}
