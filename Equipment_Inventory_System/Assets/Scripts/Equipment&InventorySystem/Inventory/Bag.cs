using System.Collections.Generic;
using UnityEngine;

public class Bag : Item
{
    public byte size;
    public List<Item> Items { get; }

    public Bag(byte _size)
    {
        size = _size;
        Items = new List<Item>();
    }

    public bool AddItem(Item item)
    {
        if (Items.Count < size)
        {
            Items.Add(item);
            return true;
        }
        else
        {
            Debug.Log("Bag is full.");
            return false;
        }
        
    }

    public bool RemoveItem(Item item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            return true;
        }
        return false;
    }
}
