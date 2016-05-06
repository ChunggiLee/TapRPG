using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();

    void Start()
    {
        items.Add(new Item("armor_002", 0, "Nice Armor", 10, 10, 1, Item.ItemType.Clothes));
        items.Add(new Item("armor_009", 1, "Better Armor", 10, 10, 1, Item.ItemType.Clothes));
        items.Add(new Item("potion_08", 2, "Nice Armor", 10, 10, 1, Item.ItemType.Consumable));
        


    }
}
