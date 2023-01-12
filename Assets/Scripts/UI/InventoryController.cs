using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField]
    private InventoryUI InventoryUI;

    public int inventorySize = 24;

    private void Start()
    {
        InventoryUI.InitializeInventory(inventorySize);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (InventoryUI.isActiveAndEnabled == false)
            {
                InventoryUI.Show();
            }
            else
            {
                InventoryUI.Hide();
            }
        }
    }
    
}
