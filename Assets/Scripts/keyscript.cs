
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{
	public GameObject	key,initicon;
	public FenceOpen intcheck;

	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("MainCamera"))
		{
			initicon.SetActive(true);
			if (Input.GetKey(KeyCode.E))
			{
				key.SetActive(false);
				
				intcheck.fencecheck = 1;
				initicon.SetActive(false);
				Destroy(initicon);
			}
		}
	}
    private void OnTriggerExit(Collider other)
    {
		initicon.SetActive(false);
    }

}

