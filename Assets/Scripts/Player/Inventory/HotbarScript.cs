using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarScript : MonoBehaviour
{
    Transform hotbarTransform;
    Transform playerTransform;
    int length = 10;
    int xOffset;
    int yOffset;
    int tileSeparation;
    [SerializeField] List<string> itemIDs;
    InventoryTile[] inventoryTiles;

    // Start is called before the first frame update
    void Start()
    {
        if (itemIDs == null) {
            itemIDs = new List<string>();
            for (int n = 0; n < length; n ++) {
                itemIDs.Add(null);
            }
        }
        for (int i = 0; i < length; i ++) {
            inventoryTiles[i] = new InventoryTile(itemIDs[i], xOffset + tileSeparation, yOffset);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
