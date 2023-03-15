using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using SaveIsEasy;

public class PauseMenu : MonoBehaviour
{
    private string sceneFileName;
    private Scene selected;
    public static bool GameIsPaused=false;
    public GameObject pauseMenuUi;
    public static bool Pausable;
    // Start is called before the first frame update
    void Start()
    {
        selected = SceneManager.GetSceneAt(0);
        sceneFileName = SaveIsEasyAPI.GetSceneFileNameByScene(selected);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Pausable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Pausable)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused == true)
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
       
    }
    public void Pause()
    {
        Debug.Log("Game Paused");
       
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        PlayerController.canMove = false;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Gun.allowedToShoot = false;
        
    }    
    public void Resume()
    {
        Debug.Log("Game Resumed");
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        PlayerController.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        GameIsPaused = false;
        Gun.allowedToShoot=true;
        


    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit(); 
    }
    public void SaveGame()
    {

        SaveIsEasyAPI.SaveAll(selected);
    }
    public void LoadGame()
    {
        SaveIsEasyAPI.LoadAll(selected);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
