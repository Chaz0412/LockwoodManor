using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteract : Interactable
{
    public bool isOpen;

    Animator animator;

    public AudioSource doorOpen;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isOpen = animator.GetBool("Open");
        
    }

    // Update is called once per frame
    void UpdateDoor()
    {
        doorOpen.Play();
        if(isOpen == true)
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
        if (isOpen) return "Press [E] to <color=red>close</color> the door.";
        return "Press [E] to <color=green>open</color> the door.";
    }

    public override void Interact()
    {
        UpdateDoor();
    }
}
