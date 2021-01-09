using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeDoor : Interactable
{
    public bool hasKey;
    public GameObject player;
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        hasKey = inventory.frontDoorKey;
    }

    private void Update()
    {
        hasKey = inventory.frontDoorKey;
    }

    // Update is called once per frame
    void UpdateDoor()
    {
        
    }

    public override string GetDescription()
    {
        if (!hasKey) return "You need the front door key";
        return "Press [E] to <color=green>open</color> the door.";
    }

    public override void Interact()
    {
        if(hasKey == true)
        {
            UpdateDoor();
        }        
    }
}
