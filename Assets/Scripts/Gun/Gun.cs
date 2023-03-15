using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
   

public class Gun : MonoBehaviour {
    public float damage = 10f;
    public float range = 100f;
    public AudioSource shoot;
    public AudioSource reload;
    public AudioSource empty;
    public float fireRate;
    public Camera fpsCam;
    public ParticleSystem MuzzleFlash;
    public GameObject gun;
    private float nextTimeToFire = 0f;
    public int maxAmmo;
    public int magAmmo;
    public int currentAmmo;
    public float reloadTime;
    private bool isreloading = false;
    private bool isempty = true;
    private bool isreloadable = true;
    public static bool allowedToShoot = true;
    private UpdateCurrentAmmo updateCurrentAmmo;
    private UpdateMaxAmmo updateTotalAmmo;          


    void Start()
    {
        if (currentAmmo <=0)
            currentAmmo = maxAmmo;
        if (maxAmmo<= 0)
            maxAmmo=1;
        updateCurrentAmmo=GameObject.Find("Canvas2").GetComponent<UpdateCurrentAmmo>();
        updateTotalAmmo = GameObject.Find("Canvas2").GetComponent<UpdateMaxAmmo>();
    }

    private void Update()
    {
        
      if(allowedToShoot)
        {
            if (isreloading)
            {
                return;
            }

            if (currentAmmo > 0)
            {
                isempty = false;
            }
            else
            {
                isempty = true;
            }

            if (Input.GetButtonDown("Fire1") && Time.time > nextTimeToFire)
            {

                if (isempty == false)
                {
                    nextTimeToFire = Time.time + 1f / fireRate;
                    Shoot();
                }
                else
                    empty.Play();


            }
            if (Input.GetKey("r"))
            {
                if (isreloadable == true)
                {
                    StartCoroutine(Reload());

                }

            }

            if (currentAmmo == magAmmo)
            {
                isreloadable = false;
            }
            else
                isreloadable = true;


            if (maxAmmo < 0)
            { maxAmmo = 0; }
            if (currentAmmo < 0)
            { currentAmmo = 0; }
            if (maxAmmo == 0)
            {
                isreloadable = false;
            }

            updateTotalAmmo.UpdateTotalAmmo(maxAmmo);
            updateCurrentAmmo.UpdateAmmo(currentAmmo);
        }
      else
        {
            Debug.Log("Not Allowed To Shoot");
        }
    }
    public int getMaxAmmo()
    {
        return maxAmmo;
    }
    IEnumerator Reload()
    {
        if(isreloadable==true)
        {
            
            isreloading = true;
            Debug.Log("reloading...");
            reload.Play();
            gun.GetComponent<Animator>().Play("Reload");

            yield return new WaitForSeconds(reloadTime);
            currentAmmo = magAmmo;
            maxAmmo--;
        }
        
      
        isreloading = false;
    }
    void Shoot()
    {
        RaycastHit hit;
        currentAmmo--;
        gun.GetComponent<Animator>().Play("Fire");
        shoot.Play();
        MuzzleFlash.Play();
        
        


        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))

        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            DoorHP doorhp = hit.transform.GetComponent<DoorHP>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if(doorhp!=null)
            {
                doorhp.TakeDamage(damage);
            }
        }
    }

    void Emptyanim()
    {
        gun.GetComponent<Animator>().Play("Empty");

    }

}
