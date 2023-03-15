using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{
    // Start is called before the first frame update
    public static float stamina=30;
    float maxStamina;
    public Slider staminaBar;
    public float dvalue;
    public float ivalue;
   
    void Start()
    {
        maxStamina = stamina;
        staminaBar.maxValue = maxStamina;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
            DecreaseEnergy();
        else if (stamina != maxStamina)
            Invoke("IncreaseEnergy", 1f);
        staminaBar.value = stamina; 
        if (stamina==0)
        {
         
        }
        



    }
    private void DecreaseEnergy()
    {
        if (stamina != 0)
        {
            stamina -= dvalue * Time.deltaTime;
        }
    }
    private void IncreaseEnergy()
    {
        
            stamina += ivalue * Time.deltaTime;
        if (stamina > maxStamina)
        {
            stamina = maxStamina;
        }
        if (stamina < 0)
        {
            stamina = 0;
        }
    }
    void function()
    {
        
    }
}
