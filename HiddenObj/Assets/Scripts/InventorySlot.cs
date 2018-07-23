using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

    Item item;
    public Text inventoryText;

    public void AddItem(Item newItem)
    {
        item = newItem;
        inventoryText.text = item.name;

    }

    public void ClearSlot()
    {
        item = null;
        inventoryText.text = null;
    }
}
