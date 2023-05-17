using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIVisualUpdater : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI moneyText;
    [SerializeField] private TextMeshProUGUI stuffText;
    
    private void Start()
    {
        UIShop.Instance.OnUpdateMoneyAmount += UIShop_OnUpdateMoneyAmount;
        UIShop.Instance.OnUpdateStuffAmount += UIShop_OnUpdateStuffAmount;
    }

    private void UIShop_OnUpdateStuffAmount(int stuff)
    {
        stuffText.text = stuff.ToString();
    }

    private void UIShop_OnUpdateMoneyAmount(int amount)
    {
        moneyText.text = amount.ToString();
    }    
}
