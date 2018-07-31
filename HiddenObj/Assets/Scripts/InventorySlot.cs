using UnityEngine;
using TMPro;

public class InventorySlot : MonoBehaviour {

    Item item;
    public TextMeshProUGUI textmesh;
        

    public void AddItem(Item newItem)
    {
        Debug.Log("Inventory Slot, adding item: " + newItem.name);

        item = newItem;
        textmesh = GetComponent<TextMeshProUGUI>();
        textmesh.SetText(newItem.name);
        item.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;
        textmesh.SetText("");  
    }
}
