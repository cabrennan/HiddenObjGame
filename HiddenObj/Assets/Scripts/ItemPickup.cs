
using UnityEngine;

public class ItemPickup: Interactable {

    public Item item;
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;


    public override void Interact()
    {
        base.Interact();
        OnMouseDown();
    }

    //void Pickup()
    void OnMouseDown()
    {

        Debug.Log("AKA: " + item.name);
        //remove from scene
        Destroy(gameObject);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
