using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    public float growthTime = 5f; // Time in seconds to reach full growth
    private float growthTimer = 0f;
    private Vector3 initialScale;
    private Vector3 finalScale = new Vector3(0.5f, 1f, 0.5f); // Adjust as needed
    private bool isFullyGrown = false;

    void Start()
    {
        initialScale = transform.localScale;
        transform.localScale = Vector3.zero; // Start at zero size
    }

    void Update()
    {
        if (growthTimer < growthTime)
        {
            growthTimer += Time.deltaTime;
            transform.localScale = Vector3.Lerp(initialScale, finalScale, growthTimer / growthTime);

            // If growthTimer is finished, mark plant as fully grown
            if (growthTimer >= growthTime)
            {
                isFullyGrown = true;
            }
        }
    }

    // Public method to check if the plant is fully grown
    public bool IsFullyGrown()
    {
        return isFullyGrown;
    }
}
