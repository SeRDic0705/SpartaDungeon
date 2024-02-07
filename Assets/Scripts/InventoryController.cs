using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public delegate void OnClickSlot();
    public OnClickSlot onClickSlot;

    [SerializeField] private Button confirmBtn;
    [SerializeField] private Text text;
    [SerializeField] private GameObject popup;
    
    void Start()
    {
        confirmBtn.onClick.AddListener(OnConfirm);
    }

    public void openPopup(Item item, OnClickSlot onClickSlot)
    {
        Debug.Log("2");
        string msg;
        if (item.isEquipped) msg = "장착 해제하시겠습니까?";
        else msg = "장착하시겠습니까?";
        text.text = msg;
        popup.SetActive(true);
        this.onClickSlot = onClickSlot;

    }

    void OnConfirm()
    {
        if (onClickSlot != null)
            onClickSlot();
    }
}
