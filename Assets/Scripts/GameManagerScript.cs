using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{ // TODO: Instead of having all these functions here, we should use inheritance to create an Item base class that Fruit and Seed can inherit from.
  //For demo purposes, just consolidating it all here to make life easy
    public int seedCount = 3; // Current Seed Count
    public int fruitCount = 0; // Current Fruit Count
    public int currency = 0; // Currency
    private UIManager uiManager;
    void Start()
    {
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        uiManager.updateSeedCount(seedCount);
        uiManager.updateFruitCount(fruitCount);
        uiManager.updateCurrency(currency);
    }
    public void UseSeed()
    {
        if (seedCount > 0)
        {
            seedCount--;
            uiManager.updateSeedCount(seedCount);
        }
    }
    public bool HasSeeds()
    {
        return seedCount > 0;
    }
    public void AddSeed(int amount)
    {
        seedCount += amount;
        uiManager.updateSeedCount(seedCount);
    }
    public bool HasFruit()
    {
        return fruitCount > 0;
    }
    public void AddFruit(int amount)
    {
        fruitCount += amount;
        uiManager.updateFruitCount(fruitCount);
    }
    public void removeFruit(int amount)
    {
        if (fruitCount > 0 && (fruitCount >= amount))
        {
            fruitCount -= amount;
        }
        else
        {
            Debug.Log("Error! You have no fruit to remove or you're trying to remove more than you have!");
        }
        uiManager.updateFruitCount(fruitCount);
    }
    public void AddCurrency(int amount)
    {
        currency += amount;
        uiManager.updateCurrency(currency);
    }
}
