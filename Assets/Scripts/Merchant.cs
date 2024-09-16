using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : MonoBehaviour
{
    public int fruitToCurrencyRate = 5; // 1 Fruit = 5 Currency
    private GameManagerScript gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }
    //Trade fruit for currency
    public void SellFruit()
    {
        if (gameManager.fruitCount > 0)
        {
            gameManager.removeFruit(1); //Remove 1 fruit
            gameManager.AddCurrency(fruitToCurrencyRate);
        }
    }
    void OnMouseDown()
    {
        SellFruit();
    }
}
