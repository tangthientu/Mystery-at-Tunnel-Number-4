
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript2 : MonoBehaviour
{
	public GameObject inticon, key;

	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("MainCamera"))
		{
			inticon.SetActive(true);
			if (Input.GetKey("e"))
			{
				key.SetActive(false);
				Portal.keyfound2 = true;
				inticon.SetActive(false);
			}
		}
	}
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("MainCamera"))
		{
			inticon.SetActive(false);
		}
	}
}
