
using UnityEngine;

public class ItemPickup: Interactable {

    public Item item;

    public override void Interact()
    {
        base.Interact();
        //Pickup();

        
    }

    //void Pickup()
    void OnMouseDown()
    {
        Debug.Log("picking up: " + item.name);
        //remove from inventory
        //remove from scene
        Destroy(gameObject);
    }
}
