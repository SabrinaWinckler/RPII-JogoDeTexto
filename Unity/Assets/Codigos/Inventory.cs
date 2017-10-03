using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour {

    GameObject inventoryPanel;
    GameObject slotPanel;
    public ItemDatabase database;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<ItemJson> items = new List<ItemJson>();
    public List<GameObject> slots = new List<GameObject>();

    private void Start()
    {

        database = GetComponent<ItemDatabase>();
        slotAmount = 12;
        inventoryPanel = GameObject.Find("Panel_Inventario");
        slotPanel = inventoryPanel.transform.Find("Panel_Slots").gameObject;
        for(int i = 0; i < slotAmount; i++)
        {
            items.Add(new ItemJson());
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);

        }
        AddItem(0);
    }

    public void AddItem(int id)
    {
        ItemJson itemToAdd = database.FetchItemByID(id);
        for (int i = 0; i < slots.Count; i++)
        {
            if(items[i].ID == -1)
            {
                items[i] = itemToAdd;
                GameObject itemObj = Instantiate(inventoryItem);
                itemObj.transform.SetParent(slots[i].transform);
                itemObj.transform.position = Vector2.zero;
                break;
            }
        }
         
    }

}
