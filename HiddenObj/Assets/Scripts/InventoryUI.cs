using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InventoryUI : MonoBehaviour {

    public Transform itemsParent;
    Inventory inventory;
    InventorySlot[] slots;

    // Use this for initialization
    void Start () {

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
        inventory = Inventory.instance;
        UpdateUI(inventory.items);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     
    void UpdateUI(List<Item> items)
    {
        Debug.Log("Updating UI");
        for (int i=0; i<slots.Length; i++)
        {
            Debug.Log("Top of loop I: " + i.ToString() + " Count: " + items.Count.ToString());
            if (inventory.items.Count>0 )
            {
                Debug.Log("Filling slot: " + i.ToString() + " with item: " + items[0].name);
                slots[i].AddItem(items[0]);
                items.RemoveAt(0);
                Debug.Log("Now items count is: " + items.Count.ToString());
            }
            else
            {
                Debug.Log("Skipping Slot: " + i.ToString());
            }
        }

    }

}
