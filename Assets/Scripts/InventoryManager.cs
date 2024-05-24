using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    public ScriptableItem[] weapons;

    public Text[] weaponsNames;

    public Text[] weaponsPrices;

    public InventorySlots[] weaponSlots;


    public Image[] weaponsSprites;

    public ScriptableItem[] armors;

    public Text[] armorsNames;

    public Text[] armorsPrices;

    public Image[] armorsSprites;

    public InventorySlots[] armorSlots;
    
    void Awake()
    {
        instance = this;
    }

    public void AddWeapon(ScriptableItem item)
    {
        for (int i = 0; i < weapons.Length; i++)
        {
            if(weapons[i] == null)
            {
                weapons[i] = item;
                weaponsNames[i].text = item.itemName;
                weaponsPrices[i].text = item.itemPrice;
                weaponsSprites[i].sprite = item.itemSprite;
                return;
            }
        }
    }

    public void AddArmor(ScriptableItem item)
    {
        for (int i = 0; i < armors.Length; i++)
        {
            if(armors[i] == null)
            {
                armors[i] = item;
                armorsNames[i].text = item.itemName;
                armorsPrices[i].text = item.itemPrice;
                armorsSprites[i].sprite = item.itemSprite;
                return;
            }
        }
    }
}
