using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawercon : MonoBehaviour
{


    public void OnMouseDown()
    {
            
            GetComponent<Rigidbody>().velocity= new Vector3(.5f,0,0);
            StartCoroutine (stopOpening ()); 

        
    }


    IEnumerator stopOpening()
    {
        yield return new WaitForSeconds (.8f);
        GetComponent<Rigidbody>().velocity= new Vector3(0,0,0);
        Destroy (gameObject);
        
    }
}


