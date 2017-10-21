using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{

    public GameObject inventoryPanel;
    public GameObject slotPanel;
    public ItemDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<ItemJson> items = new List<ItemJson>();
    public List<GameObject> slots = new List<GameObject>();
    public GameObject panel;

    private void Start()
    {

        database = GetComponent<ItemDatabase>();
        slotAmount = 16;
        //inventoryPanel = GameObject.Find("Panel_Inventario");
        //slotPanel = inventoryPanel.transform.Find("Panel_Slots").gameObject;
        for (int i = 0; i < slotAmount; i++)
        {
            items.Add(new ItemJson());
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);

        }

        //teste
        AddItem(0);
        AddItem(1);
        AddItem(2);
        AddItem(2);
        AddItem(2);
        AddItem(2);  
        AddItem(2);
        AddItem(2);

    }

    public void AddItem(int id)
    {
        ItemJson itemToAdd = database.FetchItemByID(id);
        if (itemToAdd.Stackable && checkItem(itemToAdd))
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
                {
                    ItemData data = slots[i].transform.GetChild(0).GetComponent<ItemData>();
                    data.amount++;
                    data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
                    break;
                }
            }
        }
        else { 
            for (int i = 0; i < slots.Count; i++)
            {
                if (items[i].ID == -1)
                {
                    items[i] = itemToAdd;
                    GameObject itemObj = Instantiate(inventoryItem);
                    itemObj.GetComponent<ItemData>().item = itemToAdd;
                    itemObj.transform.SetParent(slots[i].transform);
                    itemObj.GetComponent<Image>().sprite = itemToAdd.Sprite;
                    itemObj.transform.position = Vector2.zero;
                    itemObj.name = itemToAdd.Nome;
                    break;
                }
            }
        }
    }

    bool checkItem(ItemJson item)
    {
        for (int i = 0; i < items.Count; i++)
            if (items[i].ID == item.ID)
            return true;
        return false;
        
    }
}
