using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTile : MonoBehaviour
{
    public InventoryTile(string itemID, int xOffset, int yOffset) {
        this.item = new Item(itemID);
    }
    GameObject game_object;
    SpriteRenderer sprite_renderer;
    private Item item;
    // Start is called before the first frame update
    void Start()
    {
        game_object = new GameObject("InventoryTile");
        sprite_renderer = game_object.AddComponent<SpriteRenderer>();
        sprite_renderer.sprite = ItemManager.GetItemManager().getSprite(item.getID());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
