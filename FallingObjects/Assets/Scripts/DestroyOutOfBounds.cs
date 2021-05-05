using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound = 10.0f;
    private float topBound = 10.0f;
    // Start is calledbefore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

        else if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

    }
}
