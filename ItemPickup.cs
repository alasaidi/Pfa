using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactables 
{
    public Item item;
    CharacterStats charStats;
    public override void Interact()
    {
        base.Interact();
        Pickup();
    }
    void Pickup()
    {
        item.Use();
        Destroy(gameObject);
    }

}
