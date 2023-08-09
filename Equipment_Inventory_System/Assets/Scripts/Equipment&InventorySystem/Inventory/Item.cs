using UnityEngine;

public class Item
{
    public string name;
    public ItemType type;
    public uint itemID;
    public Sprite icon;
    public byte quantity;

    public Item(string _name, ItemType _type, uint _itemID, Sprite _icon, byte _quantity)
    {
        name = _name;
        itemID = _itemID;
        icon = _icon;
        quantity = _quantity;
    }
}

public enum ItemType
{
    Bag,
    Consumable,
    TwoHandedWeapon,
    Weapon,
    Shield,
    Helmet,
    Neck,
    Body,
    Legs,
    Boots,
    Back,
    Gloves,
    Ring
}
