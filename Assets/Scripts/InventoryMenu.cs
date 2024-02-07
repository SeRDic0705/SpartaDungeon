using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class InventoryMenu : MonoBehaviour
{
    private const int Max = 9;
    public int[] inventory = new int[Max];
    public Slot[] slots = new Slot[Max];

    void Awake()
    {
        // TODO : Load JSON with Resources
        inventory[0] = 1;
        inventory[1] = 2;
        inventory[2] = 3;
    }

    void OnEnable()
    {
        for (int i=0; i < Max; i++)
        {
            slots[i].item.id = inventory[i];
            slots[i].item.init();
        }
    }

}
