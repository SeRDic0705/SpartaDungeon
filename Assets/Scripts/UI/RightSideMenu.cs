using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSideMenu : MonoBehaviour
{
    [SerializeField] private GameObject menuButtons;
    [SerializeField] private GameObject status;
    [SerializeField] private GameObject inventory;


    public void OnClickStatus()
    {
        menuButtons.SetActive(false);
        status.SetActive(true);
    }

    public void OnClickInventory()
    {
        menuButtons.SetActive(false);
        inventory.SetActive(true);
    }

    public void OnClickBackButton()
    {
        status.SetActive(false);
        inventory.SetActive(false);
        menuButtons.SetActive(true);
    }
}
