using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmPlot : MonoBehaviour
{
    public GameObject plantPrefab; // The plant to spawn
    private GameObject currentPlant;
    private bool isPlanted = false;

    void OnMouseDown()
    {
        // Plant a seed if not already planted
        if (!isPlanted && GameObject.Find("GameManager").GetComponent<GameManagerScript>().HasSeeds())
        {
            Vector3 plantPosition = transform.position + new Vector3(0, 0.07f, 0); //TODO: Hardcoded currently, but if we introduce more plants, we will want to make this more dynamic based on the plant that is growing.
            currentPlant = Instantiate(plantPrefab, plantPosition, Quaternion.identity, transform);
            GameObject.Find("GameManager").GetComponent<GameManagerScript>().UseSeed();
            isPlanted = true;
        }
    }

    // Called when the plant is harvested
    public void PlantHarvested()
    {
        isPlanted = false;
        currentPlant = null;
    }
}
