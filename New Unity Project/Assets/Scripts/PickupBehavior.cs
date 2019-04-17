using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour {
    public Item item;
    private Inventory inventory;

	// Use this for initialization
	void Start () {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();	
	}
	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            bool result = inventory.Add(item);

            if (result) GameObject.Destroy(item);
        }
    }
}
