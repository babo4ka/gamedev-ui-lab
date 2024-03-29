using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateDialogUIComponent : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    private float _openTime;
    
    public void Open()
    {
        gameObject.SetActive(true);
        canvasGroup.alpha = 0.0f;
    }

    void Update()
    {
        if(canvasGroup.alpha < 1.0f)
        {
            canvasGroup.alpha += 0.01f;
        }
    }
}
