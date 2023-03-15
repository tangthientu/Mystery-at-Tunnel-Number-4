using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUITrans : MonoBehaviour
{
    public float aValue;
    private CanvasGroup trans;
    void Start()
    {
        trans = GetComponent<CanvasGroup>();
        trans.alpha =aValue;
    }

}
