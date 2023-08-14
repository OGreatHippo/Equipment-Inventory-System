using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject InventoryPanel;
    public GameObject BagsPanel;
    public GameObject bagSlot;
    public GameObject itemSlot;

    public List<BagSlot> bagSlots;
    //private List<Bag> bags;
    private byte bagCount = 5;
    public List<ItemSlot> itemSlots;
    private byte inventorySize = 3;


    // Start is called before the first frame update
    void Start()
    {
        InitaliseInventory();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitaliseInventory()
    {
        for(uint i = 0; i < bagCount; i++)
        {
            var newBagSlot = Instantiate(bagSlot);

            newBagSlot.transform.SetParent(BagsPanel.transform);

            bagSlots.Add(newBagSlot.GetComponent<BagSlot>());
        }

        for (uint i = 0; i < inventorySize; i++)
        {
            var newItemSlot = Instantiate(itemSlot);

            newItemSlot.transform.SetParent(InventoryPanel.transform);
        }
    }
}
