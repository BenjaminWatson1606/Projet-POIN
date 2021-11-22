using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ball : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "goal")
        {
            Destroy (gameObject);
            
        
        }
    }


    
}
