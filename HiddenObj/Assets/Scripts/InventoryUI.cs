﻿using UnityEngine;

public class InventoryUI : MonoBehaviour {

    public GameObject inventoryUI;  //the entire UI
    Inventory inventory;

    // Use this for initialization
    void Start () {

        Debug.Log("Starting inventory UI");
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        UpdateUI();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     
    void UpdateUI()
    {
        Debug.Log("Inside UpdateUI");
        InventorySlot[] slots = GetComponentsInChildren<InventorySlot>();
        Debug.Log("num slots found: " + slots.Length);

        for (int i=0; i<slots.Length; i++)
        {
            Debug.Log("Top of loop I: " + i.ToString());
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }

        }
        Debug.Log("after updateUI loop");

    }

}
