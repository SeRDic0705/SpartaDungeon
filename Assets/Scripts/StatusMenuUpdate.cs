using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusMenuUpdate : MonoBehaviour
{
    [SerializeField] private Text atk;
    [SerializeField] private Text def;
    [SerializeField] private Text hp;
    [SerializeField] private Text crit;
    

    void OnEnable()
    {
        PlayerCharacter player = GameManager.instance.player;
        atk.text = player.atk.ToString();
        def.text = player.def.ToString();
        hp.text = player.hp.ToString();
        crit.text = player.crit.ToString();
    }
}
