using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOff : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    public GameObject player;
    public GameObject UI;
    private void OnTriggerStay(Collider other)
    {
        Invoke("switchcam", 2);
    }
    void switchcam()
    {
        car.SetActive(false);
        player.SetActive(true);
        UI.SetActive(true);
    }
}
