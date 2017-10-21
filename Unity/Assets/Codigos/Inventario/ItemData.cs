﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
<<<<<<< Updated upstream:Unity/Assets/Codigos/Inventario/ItemData.cs

namespace Inventario {

    public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {
        public ItemJson item;
        public int amount;

        private Transform originalParent;
        private Vector2 offset;

        public void OnBeginDrag(PointerEventData eventData) {
            if (item != null) {
                offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
                originalParent = this.transform.parent;
                this.transform.SetParent(this.transform.parent.parent);
                this.transform.position = eventData.position - offset;
            }
=======

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler {
    public ItemJson item;
    public int amount;
    public int slot;

   // private Transform originalParent;
    private Inventory inv;
    private Tooltip tooltip;
    private Vector2 offset;

    void Start()
    {
        inv = GameObject.Find("Inventory").GetComponent<Inventory>();
        tooltip = inv.GetComponent<Tooltip>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (item != null)
        {
            offset = eventData.position - new Vector2(this.transform.position.x, this.transform.position.y);
            //originalParent = this.transform.parent;
            this.transform.SetParent(this.transform.parent.parent);
            this.transform.position = eventData.position - offset;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
>>>>>>> Stashed changes:Unity/Assets/Codigos/ItemData.cs
        }

        public void OnDrag(PointerEventData eventData) {
            if (item != null) {
                this.transform.position = eventData.position - offset;
            }
        }

<<<<<<< Updated upstream:Unity/Assets/Codigos/Inventario/ItemData.cs
        public void OnEndDrag(PointerEventData eventData) {
            this.transform.SetParent(originalParent);
        }
    }

}
=======
    public void OnEndDrag(PointerEventData eventData)
    {
        this.transform.SetParent(inv.slots[slot].transform);
        this.transform.position = inv.slots[slot].transform.position;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.Activate(item);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.Deactivate();
    }
}
>>>>>>> Stashed changes:Unity/Assets/Codigos/ItemData.cs
