using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyShopScript : MonoBehaviour
{
    [SerializeField] private UIShop uiShop;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<FirstPersonController>() != null)
        {
            uiShop.ShowBuyShop(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        uiShop.ShowBuyShop(false);
    }
}
