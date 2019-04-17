using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Item",menuName="Inventory/New Item")]
public class Item : ScriptableObject {
    new public string name = "New item";
    public Sprite img = null;
    public string description = null;
}
