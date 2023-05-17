using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIShop : MonoBehaviour
{
    public event Action<int> OnUpdateMoneyAmount;
    public event Action<int> OnUpdateStuffAmount;

    public static UIShop Instance;

    [SerializeField] private Button sell1Button;
    [SerializeField] private Button sell5Button;
    [SerializeField] private Button buy1Button;
    [SerializeField] private Button buy5Button;

    [SerializeField] private GameObject SellShop;
    [SerializeField] private GameObject BuyShop;

    [SerializeField] private SoundsHandling soundsHandling;

    private int pricePerOneStuff = 50;

    private int stuffAmount = 6;
    private int moneyAmount = 300;

    private void Awake()
    {
        Instance = this;

        ShowSellShop(false);
        ShowBuyShop(false);        

        sell1Button.onClick.AddListener(() =>
        {
            SellSomeShit(1);
        });
        sell5Button.onClick.AddListener(() =>
        {
            SellSomeShit(5);
        });

        buy1Button.onClick.AddListener(() =>
        {
            BuySomeShit(1);
        });
        buy5Button.onClick.AddListener(() =>
        {
            BuySomeShit(5);
        });
    }

    private void Start()
    {
        UpdateStuffAndMoneyAmount();
    }

    public void UpdateStuffAndMoneyAmount()
    {        
        OnUpdateStuffAmount?.Invoke(stuffAmount);
        OnUpdateMoneyAmount?.Invoke(moneyAmount);
    }

    public void ShowSellShop(bool show)
    {
        SellShop.SetActive(show);
    }

    public void ShowBuyShop(bool show)
    {
        BuyShop.SetActive(show);
    }

    public void SellSomeShit(int amount)
    {
        if (stuffAmount >= amount)
        {
            stuffAmount -= amount;
            moneyAmount += (amount * pricePerOneStuff);
            UpdateStuffAndMoneyAmount();
        }
        else
            soundsHandling.Croak();
            
    }
    public void BuySomeShit(int amount)
    {
        if (moneyAmount >= amount * pricePerOneStuff)
        {
            moneyAmount -= amount * pricePerOneStuff;
            stuffAmount += amount ;
            UpdateStuffAndMoneyAmount();            
        }
        else
            soundsHandling.Bark();
    }
}
