using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [HideInInspector]public PlayerCharacter player;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            player = new PlayerCharacter();
        }
        else
            Destroy(gameObject);

    }

}
