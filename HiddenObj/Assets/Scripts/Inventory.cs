﻿//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;

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


   // public delegate void OnItemChanged();
   // public OnItemChanged onItemChangedCallback;
    public int space = 15; // number of inventory slots 
    //public List<Item> items = new List<Item>();

    private void Start()
    {
        //items = GetSceneItems();
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

}
