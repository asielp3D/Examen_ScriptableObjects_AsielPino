using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    public ScriptableItem item;
    

    private SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Awake()
    {
        spriteRenderer = GetComponent <SpriteRenderer>();
    }

   
    void Start()
    {
       spriteRenderer.sprite = item.itemSprite;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            if(gameObject.layer == 6)
            {
                InventoryManager.instance.AddWeapon(item);
            }

            if(gameObject.layer == 7)
            {
                 InventoryManager.instance.AddArmor(item);
            }
        }
    
        Destroy(this.gameObject);
    }
}
