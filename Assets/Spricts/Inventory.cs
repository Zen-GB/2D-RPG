using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Collectable;

[System.Serializable]
public class Inventory
{
    [System.Serializable]
    public class Slot
    {
        public CollectableType type;
        public int count;
        public int maxAllowed;
        public string name;
        public string description;

        //create a slot for collectable
        public Slot ()
        {
            type = CollectableType.NONE;
            count = 0;
            maxAllowed = 99;
        }

        //check if collectable < max = true, else = false
        public bool CanAddItem ()
        {
            if (count < maxAllowed)
            {
                return true;
            }
            return false;
        }

        //function add item
        public void AddItem (CollectableType type)
        {
            this.type = type;
            count++;
        }
    }

    //create list name Slot
    public List<Slot> slots = new List<Slot>();

    //add slot to inventory
    public Inventory (int numSlots)
    {
        for (int i = 0; i < numSlots; i++)
        {
            //use for to create new slot (in class Player, Inventory (21), so list have 21 slot in inventory.
            Slot slot = new Slot ();
            slots.Add(slot);
        }
    }

    public void Add(CollectableType typeToAdd)
    {
        //In list stack Slot, if collectable have the same type and function CanAddItem is true, item will add into Inventory with 1 slot 
        foreach (Slot slot in slots)
        {
            if (slot.type == typeToAdd && slot.CanAddItem())
            {
                slot.AddItem (typeToAdd);
                return;
            }
        }
        //In list stack Slot, if collectable is new type, item will add into new slot in Inventory
        foreach (Slot slot in slots)
        {
            if (slot.type == CollectableType.NONE)
            {
                slot.AddItem (typeToAdd);
                return;
            }
        }
    }
}
