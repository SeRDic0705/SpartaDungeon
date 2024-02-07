using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public int id = 0;
    public int atk { get; set; } = 0;
    public int def { get; set; } = 0;
    
    public bool isEquipped = false;

    public void init()
    {
        if (id != 0)
            GetComponent<Image>().sprite = Resources.Load<Sprite>("ItemSprites/" + id.ToString());
    }
}
