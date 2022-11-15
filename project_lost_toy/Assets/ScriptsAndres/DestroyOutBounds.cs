using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float leftBound = -278.0f;
   private float rightBound = -310.0f;
   
    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.z < rightBound){
            Destroy(gameObject);
        }else if (transform.position.z > leftBound){
            Destroy(gameObject);
        }
        
    }
}
