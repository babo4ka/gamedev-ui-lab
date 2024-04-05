using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateDialogUIComponent : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public Button closeBtn;


    public AnimationCurve animCurve;

    private void Start()
    {
        closeBtn.onClick.AddListener(CloseRatePanel);
    }

    public void Open()
    {
        gameObject.SetActive(true);
    }

    private void CloseRatePanel()
    {
        gameObject.SetActive(false);
    }
}
