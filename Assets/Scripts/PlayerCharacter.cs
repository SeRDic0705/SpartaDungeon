using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter
{
    private string name { get; set; }
    private int level { get; set; }
    private int exp { get; set; }
    private int atk { get; set; }
    private int def { get; set; }
    private int hp { get; set; }
    private int crit { get; set; }

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
}
