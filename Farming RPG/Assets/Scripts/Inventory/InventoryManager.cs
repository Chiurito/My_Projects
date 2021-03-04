
using System;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : SingletonMonobehaviour<InventoryManager>
{
    private Dictionary<int, ItemDetails> itemDetailsDictionary;

    [SerializeField] private SO_ItemList itemList = null;

    private void Start()
    {
        // Create item details dictionary
        CreateItemdDetailsDictionary();
    }

    /// <summary>
    /// Populates the itemDetailsDictionary from the scriptable object items list
    /// </summary>
    private void CreateItemdDetailsDictionary()
    {
        itemDetailsDictionary = new Dictionary<int, ItemDetails>();

        foreach (ItemDetails itemDetails in itemList.itemDetails)
        {
            itemDetailsDictionary.Add(itemDetails.itemCode, itemDetails);
        }
    }

    /// <summary>
    /// Returns the itemDetails (from the SO_ItemList) for the itemCode, or null if the item code doesen't exist
    /// </summary>
    
    public ItemDetails GetItemDetails(int itemCode)
    {
        ItemDetails itemDetails;
        
        if(itemDetailsDictionary.TryGetValue(itemCode, out itemDetails))
        {
            return itemDetails;
        }
        else
        {
            return null;
        }
    }

}
