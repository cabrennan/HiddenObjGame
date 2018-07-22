
using UnityEngine;

public class ItemPickup: Interactable {

    public Item item;



    public override void Interact()
    {
        base.Interact();

        OnMouseDown();
    }

    //void Pickup()
    void OnMouseDown()
    {

        Debug.Log("picking up: " + transform.name);
        Debug.Log("AKA: " + item.name);
        //remove from scene
        Destroy(gameObject);

    }
}
