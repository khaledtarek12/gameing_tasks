using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3Script : MonoBehaviour
{
    public float growthRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float growthAmount = growthRate * Time.maximumParticleDeltaTime;

        // Get the current scale of the cube
        Vector3 currentScale = transform.localScale;
        
        // Increase the y-scale by the growth amount
        currentScale.y += growthAmount;
        
        // Update the cube's scale with the new scale
        transform.localScale = currentScale;
    }
}
