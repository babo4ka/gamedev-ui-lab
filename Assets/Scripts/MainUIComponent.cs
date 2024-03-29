using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIComponent : MonoBehaviour
{

    [SerializeField]
    private Button rateButtonToggler;

    public GameObject rateDialog;

    void Start()
    {
        
        rateButtonToggler.onClick.AddListener(ToggleRatePanel);
    }

    private void ToggleRatePanel()
    {
        rateDialog.GetComponent<RateDialogUIComponent>().Open();
    }
}
