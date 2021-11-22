using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prerequisite : MonoBehaviour
{
    public bool requireItem;

    public Switcher watchSwitcher;

    public Collector checkCollector;

    public bool nodeAccess;


    public bool Complete
    {
        get {
            if(!requireItem){
                return watchSwitcher.state;
            }else {
                return GameManager.ins.itemHeld.itemName == checkCollector.myItem.itemName;
            }
        }
            
    }
}
