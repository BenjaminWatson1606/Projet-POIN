using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    public static GameManager ins;
    public IVCanvas ivCanvas;
    public ObsCamera ObsCamera;
    public InventoryDisplay InvDisp;

    public Node startingNode; 

    [HideInInspector]
    public Node currentNode;
    public Item itemHeld;
    public CameraRig rig;

    void Awake(){
        ins = this;
        ivCanvas.gameObject.SetActive(false);
        ObsCamera.gameObject.SetActive(false);
    }

    void Start()
    {
        startingNode.Arrive (); 

    }
    void Update()
    {
        if (Input.GetMouseButtonDown (1) && currentNode.GetComponent<Prop> () != null) {
            if (ivCanvas.gameObject.activeInHierarchy){
                ivCanvas.Close ();
                return;
            }
            if (ObsCamera.gameObject.activeInHierarchy){
                ObsCamera.Close ();
                return;
            }
            currentNode.GetComponent<Prop>().loc.Arrive();
        } 
        
    }
}
