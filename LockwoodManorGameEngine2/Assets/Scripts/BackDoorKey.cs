using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackDoorKey : Interactable
{
    public Inventory inventory;
    
    // Update is called once per frame
    void UpdateKey()
    {
        inventory.backDoorKey = true;
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
