using System.Collections.Generic;
using UnityEngine;


public class Inventory : MonoBehaviour {

    public GameObject inventoryPanel;
    public GameObject slotPanel;
    public GameObject inventorySlot;
    public GameObject inventoryItem;

    int slotAmount;
    public List<ItemJson> items = new List<ItemJson>();
    public List<GameObject> slots = new List<GameObject>();

    private void Start()
    {
        slotAmount = 12;
        inventoryPanel = GameObject.Find("Panel_Inventario");
        slotPanel = inventoryPanel.transform.Find("Panel_Slots").gameObject;
        for(int i = 0; i < slotAmount; i++)
        {
            slots.Add(Instantiate(inventorySlot));
            slots[i].transform.SetParent(slotPanel.transform);

        }
    }

}
