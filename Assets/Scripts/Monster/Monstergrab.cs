using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Monstergrab : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    
    public GameObject enemygrab;
    public GameObject player,gun;
    public Animator animator;
    public int dmg;

    private void Start()
    {
        
        animator.GetComponent<Animator>();
       
    }
   void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Playergrab"))
        {
            
            
            enemy.GetComponent<NavMeshAgent>().isStopped = true;
            animator.SetBool("IsAttack", true);
            animator.SetBool("IsMoving", false);
            Invoke("dealDmg", 1f);
        }
       
    }
    /*void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Playergrab"))
        {
            enemy.GetComponent<NavMeshAgent>().isStopped = true;
            animator.SetBool("IsAttack", true);
            animator.SetBool("IsMoving", false);

            Debug.Log("attack");
            Invoke("dealDmg", 1f);
        }

    }*/
    public PlayerHP PlayerHP;
   void dealDmg()
    {
        PlayerHP.TakeDamage(20);
    }
    // Update is called once per frame
    private void OnTriggerExit(Collider other)
    {
        continutechase();

    }
    void Update()
    {
        
    }
   void continutechase()
    {
        enemy.GetComponent<NavMeshAgent>().isStopped = false;
        animator.SetBool("IsAttack", false);
        animator.SetBool("IsMoving", true);
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }
}
