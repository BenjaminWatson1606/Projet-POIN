using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Ball")
        {
            Destroy (gameObject);
            
        }
    }


    
}