﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Catalogo {
    public class Tooltip : MonoBehaviour {

        private ItemJson item;
        private string data;
        private GameObject tooltip;

        void Start() {
            tooltip = GameObject.Find("Tooltip");
            tooltip.SetActive(false);
        }

        void Update() {
            if (tooltip.activeSelf) {
                tooltip.transform.position = Input.mousePosition;
            }
        }

        public void Activate(ItemJson item) {
            this.item = item;
            ConstructDataString();
            tooltip.SetActive(true);
        }

        public void Deactivate() {
            tooltip.SetActive(false);
        }

        public void ConstructDataString() {
            data = "<b>" + item.Nome + "</b>\n\n" + item.Descricao + "\n";
            tooltip.transform.GetChild(0).GetComponent<Text>().text = data;
        }
    }
}