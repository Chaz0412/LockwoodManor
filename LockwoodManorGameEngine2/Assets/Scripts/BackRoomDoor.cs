using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRoomDoor : Interactable
{
    public bool isOpen;

    Animator animator;

    public AudioSource doorOpen;

    public Inventory inventory;

    public bool hasKey;

    // Start is called before the first frame update
    void Start()
    {
        hasKey = inventory.backDoorKey;
        animator = GetComponent<Animator>();
        isOpen = animator.GetBool("Open");
    }

    void Update()
    {
        hasKey = inventory.backDoorKey;
    }

    // Update is called once per frame
    void UpdateDoor()
    {
        doorOpen.Play();
        if (isOpen == true)
        {
            animator.SetBool("Open", false);
            isOpen = false;
        }
        else
        {
            animator.SetBool("Open", true);
            isOpen = true;
        }

    }

    public override string GetDescription()
    {
        if (!hasKey) return "You need the back door key";
        if (isOpen) return "Press [E] to <color=red>close</color> the door.";
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
