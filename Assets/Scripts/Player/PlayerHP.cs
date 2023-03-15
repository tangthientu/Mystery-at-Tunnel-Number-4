using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider HPbar;
    public float CurrentHP;
    public float MaxHP = 100;
    public float Heal;
    public float ivalue = 1;
    public float hurtscreendelay;
    public GameObject hurtscreen;
    public Animator animator;
    public GameObject GameoverScreen;
    
   


    void Start()
    {
        
        CurrentHP = MaxHP;
        HPbar.maxValue = MaxHP;
        Invoke("enablehurtscreen",3f);
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
        HPbar.value = CurrentHP;
        if (CurrentHP > MaxHP)
        {
            CurrentHP = MaxHP;
        }
        if (Input.GetKeyDown("o"))
        {
            TakeDamage(20);
        }
        if (Input.GetKeyDown("p"))
        {
            Healing(5);
        }
        if (CurrentHP != MaxHP)
        {
            Invoke("Regen", 2f);
        }
        if(hurtscreen != null)
        {
            if(hurtscreen.GetComponent<Image>().color.a>0)
            {
                var color = hurtscreen.GetComponent<Image>().color;
                color.a -= hurtscreendelay;
                hurtscreen.GetComponent<Image>().color = color;
            }
        }
        if(CurrentHP<=0)
        {
            Debug.Log("player died");
            PauseMenu.Pausable = false;
            animator.SetBool("IsDead",true);
        }

    }
    public void TakeDamage(float Dmg)
    {
        var color = hurtscreen.GetComponent<Image>().color;
        color.a = 0.8f;
        hurtscreen.GetComponent<Image>().color = color;
        CurrentHP -= Dmg;


    }
    public void Healing(float healthPoints)
    {
        CurrentHP += healthPoints;
        CurrentHP = Mathf.Clamp(CurrentHP, 0, 100);

    }
    public void Regen()
    {
        CurrentHP += ivalue * Time.deltaTime;


    }
    void enablehurtscreen()
    {
        hurtscreen.SetActive(true);
    }


        
    public void playerdeath()
    {
        PlayerController.canMove = false;
        Invoke("gameoverscreen", 0.5f);
        animator.SetBool("IsRevived", false);
    }
    public void revivePlayer()
    {
        CurrentHP = MaxHP;
        PlayerController.canMove = true;
        animator.SetBool("IsDead", false);
        animator.SetBool("IsRevived", true);
    }
    void gameoverscreen()
    {
        GameoverScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }    
}
  
