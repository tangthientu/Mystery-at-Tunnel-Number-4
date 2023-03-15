using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TBCscreen : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TBC;
    public GameObject Credit;
    void Start()
    {
        PlayerController.canMove = false;
        Gun.allowedToShoot = false;
    }

    // Update is called once per frame
    void Update()
    {

        Invoke("creditroll", 3f);
    }
    void mainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    void creditroll()

    {

        
        Credit.SetActive(true);
        Invoke("changetonextscene", 2f);
    }
    void changetonextscene()
    {
        SceneManager.LoadScene("Level2");
    }
}
