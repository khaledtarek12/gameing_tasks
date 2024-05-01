using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cub2Script : MonoBehaviour
{
    public float rotationSpeed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAmount = rotationSpeed * Time.maximumDeltaTime;
        transform.Rotate(0f, 0f, rotationAmount);
    }
}
