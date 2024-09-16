using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI seedCountText;
    public TextMeshProUGUI fruitCountText;
    public TextMeshProUGUI currencyText;

    public void updateSeedCount(int seedCount)
    {
        seedCountText.text = "Seeds: " + seedCount.ToString();
    }
    public void updateFruitCount(int fruitCount)
    {
        fruitCountText.text = "Fruit: " + fruitCount.ToString();
    }
    public void updateCurrency(int currency)
    {
        currencyText.text = "Currency: " + currency.ToString();
    }
}
