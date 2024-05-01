using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cub1Script : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    public float zPositionChange = 1f; 
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToMove = zPositionChange * speed * Time.maximumParticleDeltaTime;
        Vector3 currentPosition = transform.position;
        currentPosition.z += distanceToMove;
        transform.position = currentPosition;
    }
}
