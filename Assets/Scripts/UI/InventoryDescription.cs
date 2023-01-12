using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryDescription : MonoBehaviour
{
    public Image itemImg;
    public TMP_Text title;
    public TMP_Text description;

    public void ResetDescription()
    {
        itemImg.gameObject.SetActive(false);
        title.text = "";
        description.text = "";
    }

    public void SetDescription(Sprite sprite, string itemName, string itemDescription)
    {
        itemImg.gameObject.SetActive(true);
        itemImg.sprite = sprite;
        title.text = itemName;
        description.text = itemDescription;
    }
}
