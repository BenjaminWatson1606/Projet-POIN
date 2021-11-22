using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Node : MonoBehaviour
{
    public Transform cameraPosition;
    public List<Node> ReachableNodes = new List<Node>();
    public float pressure;
    

    [HideInInspector]
    public Collider col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
        col.enabled = false;

    }



    void OnMouseDown() {
        Arrive ();
    }

    public virtual void Arrive () {
        //leave existing current node 
        if (GameManager.ins.currentNode!= null)
            GameManager.ins.currentNode.Leave ();

        //set current node 
        GameManager.ins.currentNode = this;


        //move the camera 
       GameManager.ins.rig.AlignTo(cameraPosition);





        //turn off our own collider 
        if (col !=null)
            col.enabled = false; 

        //turn on all reachable node's colliders

        SetReachableNodes (true);
    }

        
        public virtual void Leave () {

            //turn off all reachable node's colliders
            SetReachableNodes (false);

        }

        public void SetReachableNodes (bool set) {
              foreach (Node node in ReachableNodes) {
                if (node.col !=null){
                     if (node.GetComponent<Prerequisite>() && node.GetComponent<Prerequisite>().nodeAccess){
                         if(node.GetComponent<Prerequisite>().Complete){
                            node.col.enabled = set;
                         }
                        
                    }else{
                        node.col.enabled= set;
                    }
                    
            }
        }

        }

    

}