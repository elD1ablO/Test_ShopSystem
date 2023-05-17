using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellShopScript : MonoBehaviour
{
    [SerializeField] private UIShop uiShop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonController>() != null)
        {
            uiShop.ShowSellShop(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        uiShop.ShowSellShop(false);
    }
}
