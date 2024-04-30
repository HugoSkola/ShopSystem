using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{

    public int itemID;
    public TextMeshProUGUI priceTXT;
    public TextMeshProUGUI quantityTXT;
    public GameObject shopManager;

    // Update is called once per frame
    void Update()
    {
        priceTXT.text = "Price: " + shopManager.GetComponent<ShopManager>().shopItems[2, itemID].ToString();
        quantityTXT.text = "Own " + shopManager.GetComponent<ShopManager>().shopItems[3, itemID].ToString() + " Items";
    }
}
