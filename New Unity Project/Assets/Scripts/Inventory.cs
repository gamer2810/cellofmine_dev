using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    List<Item> items;

    public int space = 20;

    public bool Add(Item item){
        if (items.Count > space)
            return false;
        items.Add(item);
        return true;
    }

    public void Remove(Item item){
        items.Remove(item);
    }
}
