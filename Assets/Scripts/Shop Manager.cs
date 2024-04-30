using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{

    public int[,] shopItems = new int[4, 4];
    public float coins;
    public TextMeshProUGUI coinsTXT;

    [SerializeField] int item1Price;
    [SerializeField] int item2Price;
    [SerializeField] int item3Price;



    // Start is called before the first frame update
    void Start()
    {

        coinsTXT.text = "Coins: " + coins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;

        //Price
        shopItems[2, 1] = item1Price;
        shopItems[2, 2] = item2Price;
        shopItems[2, 3] = item3Price;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;




    }

    public void Buy()
    {
        GameObject buttonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemID])
        {
            coins -= shopItems[2, buttonRef.GetComponent<ButtonInfo>().itemID];
            shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemID]++;

            coinsTXT.text = "Coins: " + coins.ToString();
            buttonRef.GetComponent<ButtonInfo>().quantityTXT.text = shopItems[3, buttonRef.GetComponent<ButtonInfo>().itemID].ToString();
        }
    }
}
