using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public InventoryItem itemPrefab;
    public RectTransform contentPanel;
    public Weapon weapon1;
    public Weapon weapon2;
    public Weapon weapon3;
    public Weapon weapon4;
    public InventoryDescription itemDescription;
    List<InventoryItem> itemList = new List<InventoryItem>();

    private void Awake()
    {
        Hide();
        itemDescription.ResetDescription();
    }

    public void Show()
    {
        gameObject.SetActive(true);
        itemDescription.ResetDescription();

        itemList[0].Deselect();
        itemList[1].Deselect();
        itemList[2].Deselect();
        itemList[3].Deselect();

        itemList[0].SetData(weapon1.image, weapon1.quantity);
        itemList[1].SetData(weapon2.image, weapon2.quantity);
        itemList[2].SetData(weapon3.image, weapon3.quantity);
        itemList[3].SetData(weapon4.image, weapon4.quantity);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void InitializeInventory(int invSize)
    {
        for (int i = 0; i < invSize; i++)
        {
            InventoryItem item = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            item.transform.SetParent(contentPanel);
            item.transform.localScale = Vector3.one;
            item.name = "Slot" + i;
            itemList.Add(item);

            item.OnItemClicked += HandleItemSelection;
            item.OnItemDroppedOn += HandleSwap;
            item.OnItemBeginDrag += HandleBeginDrag;
            item.OnItemEndDrag += HandleEndDrag;
            item.OnRightMouseBtnClick += HandleShowItemActions;
        }
    }

    private void HandleItemSelection(InventoryItem obj)
    {
        if (obj.name == "Slot0")
        {
            itemDescription.SetDescription(weapon1.image, weapon1.title, weapon1.description);

            itemList[0].Select();
            itemList[1].Deselect();
            itemList[2].Deselect();
            itemList[3].Deselect();
        }
        else if (obj.name == "Slot1")
        {
            itemDescription.SetDescription(weapon2.image, weapon2.title, weapon2.description);
            itemList[0].Deselect();
            itemList[1].Select();
            itemList[2].Deselect();
            itemList[3].Deselect();
        }
        else if (obj.name == "Slot2")
        {
            itemDescription.SetDescription(weapon3.image, weapon3.title, weapon3.description);

            itemList[0].Deselect();
            itemList[1].Deselect();
            itemList[2].Select();
            itemList[3].Deselect();
        }
        else if (obj.name == "Slot3")
        { 
            itemDescription.SetDescription(weapon4.image, weapon4.title, weapon4.description);
            
            itemList[0].Deselect();
            itemList[1].Deselect();
            itemList[2].Deselect();
            itemList[3].Select();
        }
    }

    private void HandleSwap(InventoryItem obj)
    {
        Debug.Log(obj.name);
    }

    private void HandleBeginDrag(InventoryItem obj)
    {
        Debug.Log(obj.name);
    }

    private void HandleEndDrag(InventoryItem obj)
    {
        Debug.Log(obj.name);
    }

    private void HandleShowItemActions(InventoryItem obj)
    {
        Debug.Log(obj.name);
    }
}
