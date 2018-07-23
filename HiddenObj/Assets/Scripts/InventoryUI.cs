using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InventoryUI : MonoBehaviour {

    // Needs the list from inventory here
    public List<Item> items = new List<Item>();
    //Inventory inventory;


    // Use this for initialization
    void Start () {

        items = GetSceneItems();
        //Inventory = Inventory.instance;
        //inventory.onItemChangedCallback += UpdateUI;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
     
    void UpdateUI()
    {
        Debug.Log("Updating UI");
    }

    public static List<Item> GetSceneItems()
    {
        string[] itemGuids = AssetDatabase.FindAssets("t:Item");
        List<Item> items = new List<Item>();

        foreach (string s in itemGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(s);
            Item i = AssetDatabase.LoadAssetAtPath<Item>(path);
            Debug.Log("Adding to GetSceneItems list: " + i.name);
            items.Add(i);
        }

        return items;
    }
}
