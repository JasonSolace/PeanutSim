using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestablePlant : MonoBehaviour
{
    private PlantGrowth plantGrowth;

    void Start()
    {
        plantGrowth = GetComponent<PlantGrowth>();
    }

    void OnMouseDown()
    {
        // Check if the plant is fully grown
        if (plantGrowth.IsFullyGrown())
        {
            Harvest();
        }
    }

    void Harvest()
    {
        // Increase player's inventory in GameManager
        GameObject.Find("GameManager").GetComponent<GameManagerScript>().AddFruit(1); // Adding 1 to inventory
        // Destroy the plant
        Destroy(gameObject);
        // Notify the farm plot that the plant was harvested
        FarmPlot farmPlot = GetComponentInParent<FarmPlot>();
        if (farmPlot != null)
        {
            farmPlot.PlantHarvested();
        }
    }

}
