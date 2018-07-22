using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Inventory : MonoBehaviour {
    // #region Singleton   
    // public static Inventory instance;
    // private void Awake()
    // {
    //    if(instance != null){
    //       Debug.LogWarning("Attempt to create multiple instance of inventory found");
    //       return;
    //    }
    //    instance = this;
    //  }
    // #endregion


    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Item> items = new List<Item>();

    private void Start()
    {
        items = GetSceneItems();
    }

    public static List<Item> GetSceneItems()   {
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

    public void Add(Item item)
    {
        items.Add(item);
        if (onItemChangedCallback != null) {
            onItemChangedCallback.Invoke();
        }
 
    }

    public void Remove(Item item)
    {
        items.Remove(item);
        if (onItemChangedCallback != null) {
            onItemChangedCallback.Invoke();
        }

    }

}
