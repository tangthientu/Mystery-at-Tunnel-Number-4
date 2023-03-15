using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public string scenename="level1";
    public float imagedelay=2f;
    public bool isDecreasingDone = false;
    public void PlayGame()
    {
        SceneManager.LoadScene(scenename);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayAnim()
    {
        animator.SetBool("PlayButton", true);
    }

    public Image image;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
   
    private void Update()
    {
   
    }
}
