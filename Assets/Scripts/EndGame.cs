using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject endgameScreen;
    public GameObject pCam;
    public GameObject nCam;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void endTheGame()
    {
        endgameScreen.SetActive(true);
        pCam.SetActive(false);
        PlayerController.canMove = false;
        PlayerController.AllowedToJump = false;
        Gun.allowedToShoot = false;
        PauseMenu.Pausable = false;
    }
    void switchScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
