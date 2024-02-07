using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;

    public void OnClick()
    {
        Debug.Log("click");
        if (item.id !=0)
        {
            GameManager.instance.inventoryController.openPopup(item, () => { EquipUnEquip(); });
        }
    }

    public void EquipUnEquip()
    {
        if (item.isEquipped)
        {
            item.isEquipped = false;
            GameManager.instance.player.UnEquip(item);
        }
        else
        {
            item.isEquipped = true;
            GameManager.instance.player.Equip(item);
        }
    }
}
