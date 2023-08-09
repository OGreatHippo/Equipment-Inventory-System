using System.Collections.Generic;
using UnityEngine;

public class BagsInventory : MonoBehaviour
{
    public List<Bag> Bags { get; }

    public BagsInventory()
    {
        Bags = new List<Bag>();
    }

    public void AddBag(Bag bag)
    {
        Bags.Add(bag);
    }
}
