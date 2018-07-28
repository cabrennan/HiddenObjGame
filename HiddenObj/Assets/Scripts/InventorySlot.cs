using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

    Item item;
    Item otheritem;
    public Text inventoryText;

    public void AddItem(Item newItem)
    {
        Debug.Log("Inventory Slot, adding item: " + newItem.name);

        item = newItem;
        inventoryText.text = newItem.name;
    }

    public void ClearSlot()
    {
        item = null;
        inventoryText.text = null;
    }
}
