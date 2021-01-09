using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDoorKey : Interactable
{
    public Inventory inventory;
    //public GameObject key;

    void Start()
    {
        //key = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void UpdateKey()
    {
        inventory.backDoorKey = true;
        //key.gameObject.SetActive(false);
        Destroy(gameObject);
    }

    public override string GetDescription()
    {
        return "Press [E] to pick up back door key.";
    }

    public override void Interact()
    {
        UpdateKey();
    }
}
