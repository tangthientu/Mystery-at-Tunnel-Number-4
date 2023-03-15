using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UpdateMaxAmmo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TMP_Text _ammoText;


    // Update is called once per frame

    public void UpdateTotalAmmo(int count2)
    {
        _ammoText.text = count2+"";
    }

}
