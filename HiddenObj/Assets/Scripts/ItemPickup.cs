using System.Collections.Generic;
using UnityEngine;

public class ItemPickup: Interactable {

    public Item item;   // Item to put in the inventory if picked up
    public delegate void OnItemChanged();
    public OnItemChanged onitemChangedCallback;

    // When the player interacts with the item
    public override void Interact()
    {
        base.Interact();
        Debug.Log("Inside ItemPickup");

        OnMouseDown();
    }

    // Pick up the item
    void OnMouseDown()
    {
        if (item.enabled)
        {
            Debug.Log("Picking up " + item.name);
            Inventory.instance.Remove(item);
            Destroy(gameObject);    // Destroy item from scene
        } else
        {
            Debug.Log("item not enabled yet");
        }
    }
   
}
