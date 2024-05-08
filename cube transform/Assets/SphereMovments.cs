using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovments : MonoBehaviour
{
    public float moveSpeed = 25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.UpArrow)) 
            {

                
                    transform.Translate(Vector3.forward * Time.maximumParticleDeltaTime * moveSpeed);
                
                
            }
            if (Input.GetKey(KeyCode.LeftArrow)) 
            {

                
                    transform.Translate(Vector3.left * Time.maximumParticleDeltaTime * moveSpeed);
                
                
            }
            if (Input.GetKey(KeyCode.RightArrow)) 
            {
                
                    transform.Translate(Vector3.right * Time.maximumParticleDeltaTime * moveSpeed);
                
            }
            if (Input.GetKey(KeyCode.DownArrow)) 
            {
                
                    transform.Translate(Vector3.back * Time.maximumParticleDeltaTime * moveSpeed);
                
            }
    }
}
