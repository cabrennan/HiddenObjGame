//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Inventory : MonoBehaviour {

    #region Singleton

    public static Inventory instance;
    public List<Item> items;
    void Awake()
    {
        instance = this;
        items = GetSceneItems();
    }

    #endregion

    public int space = 15; // number of inventory slots 

    private void Start()
    {

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
        //items.Remove(item);
        //if (onItemChangedCallback != null) {
        //    onItemChangedCallback.Invoke();
        //}

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
