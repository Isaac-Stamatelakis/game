using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
Singleton
O
**/
public sealed class ItemManager
{
    private static ItemManager itemManager;
    [SerializeField] List<string> itemIDs;
    [SerializeField] List<Sprite> sprites;
    private Dictionary<string, Sprite> id_to_sprite;
    private ItemManager() {
        
    }
    public static ItemManager GetItemManager() {
        if (itemManager == null) {
             itemManager = new ItemManager();
        }
        return itemManager;
    }

    public Sprite getSprite(string itemID) {
        return id_to_sprite[itemID];
    }
    




    
}
