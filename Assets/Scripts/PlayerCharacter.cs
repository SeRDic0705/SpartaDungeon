using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter
{
    public string name { get; set; }
    public int level { get; set; }
    public int exp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int hp { get; set; }
    public int crit { get; set; }

    public PlayerCharacter()
    {
        name = "Chad";
        level = 1;
        exp = 4;
        atk = 35;
        def = 40;
        hp = 100;
        crit = 25;
    }

    public void Equip(Item item)
    {
        atk += item.atk;
        def += item.def;
    }

    public void UnEquip(Item item)
    {
        atk -= item.atk;
        def -= item.def;
    }
}
