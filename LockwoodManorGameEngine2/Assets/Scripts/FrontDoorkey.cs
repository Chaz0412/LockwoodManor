using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoorkey : Interactable
{
    public Inventory inventory;
    

    // Update is called once per frame
    void UpdateKey()
    {
        inventory.frontDoorKey = true;
        
        Destroy(gameObject);
    }

    public override string GetDescription()
    {
        return "Press [E] to pick up Front door key.";
    }

    public override void Interact()
    {
        UpdateKey();
    }
}
