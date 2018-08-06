using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Inventory : MonoBehaviour {

    #region Singleton

    // items list will need Sprite association for game image
    // In heiarchy attach approriate collider to sprite
    // Attach interactibile script to item in heiarchy
    // Attach itempickup script to item in heiarchy
    // In inspector insert Inventory/items/item to variable in ItemPickup(script) dialog box. 

    public static Inventory instance;
    public List<Item> items;

     void Awake()
    {
        instance = this;
        items = GetSceneItems();
        Debug.Log("after Inventory awake");
    }

    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public int space = 15; // number of inventory slots 
    public Vector3 position;

    private void Start()
    {
        Debug.Log("inside start - load UI here?");
        
    }

    public void Add(Item item)
    {
        //items.Add(item);
        //if (onItemChangedCallback != null) {
        //    onItemChangedCallback.Invoke();
        //}
 
    }

    public void Remove(Item item)
    {
        Debug.Log("Inside inventory remove item: " + item.name);
        items.Remove(item);
        item.enabled = false;

        Debug.Log("hitting redraw UI callback next");
        if (onItemChangedCallback != null) {
            onItemChangedCallback.Invoke();
        }

    }

    public static List<Item> GetSceneItems()
    {
        string[] itemGuids = AssetDatabase.FindAssets("t:Item");
        List<Item> items = new List<Item>();


        foreach (string s in itemGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(s);
            Item i = AssetDatabase.LoadAssetAtPath<Item>(path);
            items.Add(i);
        }

        return items;

    }

}
