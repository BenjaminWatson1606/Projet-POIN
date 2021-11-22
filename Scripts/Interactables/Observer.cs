using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : Interactable
{
    public override void Interact ()
    {
        
        GameObject item = Instantiate (gameObject);
        item.transform.SetParent (GameManager.ins.ObsCamera.rig);
        item.transform.localPosition = Vector3.zero;
        item.transform.GetChild (1).localPosition = Vector3.zero;
        GameManager.ins.ObsCamera.model = item.transform;
        GameManager.ins.ObsCamera.gameObject.SetActive(true);
    }

    
}
