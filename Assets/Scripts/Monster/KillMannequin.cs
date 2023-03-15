using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMannequin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemygrab"))
        {
            gameObject.SetActive(false);
            Debug.Log("killed");
        }
    }
}
