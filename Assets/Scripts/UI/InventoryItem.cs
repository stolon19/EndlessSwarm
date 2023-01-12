using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class InventoryItem : MonoBehaviour
{
    [SerializeField]
    private Image itemImg;
    [SerializeField]
    private TMP_Text quantityTxt;

    [SerializeField]
    private Image borderImg;

    public event Action<InventoryItem> OnItemClicked, OnItemDroppedOn, OnItemBeginDrag, OnItemEndDrag;

    private bool empty = true;
}
