using UnityEngine;

public class Bag : Item
{
    public byte size;
 
    public Bag(string _name, uint _itemID, Sprite _icon, byte _size) : base(_name, ItemType.Bag, _itemID, _icon, 1)
    {
        name = _name;
        itemID = _itemID;
        icon = _icon;
        size = _size;
    }
}
