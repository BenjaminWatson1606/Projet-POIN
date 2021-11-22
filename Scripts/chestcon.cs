using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestcon : MonoBehaviour{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        
        GetComponent<Rigidbody>().angularVelocity= new Vector3(0,0,-.5f);
        StartCoroutine (stopOpening ()); 

    }

    IEnumerator stopOpening()
    {
        yield return new WaitForSeconds (1.5f);
        GetComponent<Rigidbody>().angularVelocity= new Vector3(0,0,0);
    }
}
