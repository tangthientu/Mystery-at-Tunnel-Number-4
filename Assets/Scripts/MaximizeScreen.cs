using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximizeScreen : MonoBehaviour
{
    public void fullscreen(bool is_fullscreen)
    {
        Screen.fullScreen = is_fullscreen;  
    }
}
