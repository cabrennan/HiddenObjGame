using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/Items")]
public class Item : ScriptableObject {



    new public string name = "New Item";    // Name of the item
    public Sprite icon = null;              // Item icon
    public bool showInInventory = true;
    public bool enabled = false; // If true can be clicked on

    // Called when the item is pressed in the inventory
    public virtual void Use()
    {
        // Use the item

    }

    // Call this method to remove the item from inventory
    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this); 
    }

}
