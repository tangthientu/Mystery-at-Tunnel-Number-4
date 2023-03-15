using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlerAttack : MonoBehaviour
{
    public PlayerHP HP;
    public GameObject playerFlashLight;
    public GameObject Crawler;

    private void Start()
    {
        
    }
    void attacktarget()
    {

        GameObject.Find("Player").GetComponent<PlayerHP>().TakeDamage(999);



    }
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            attacktarget();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("StopPoint"))
        {
            playerFlashLight.SetActive(false);
            Crawler.SetActive(false);
            Invoke("FLon",2f);
        }

    }
    void FLon()
    {
        playerFlashLight.SetActive(true);
        Crawler.SetActive(false);
    }
}
