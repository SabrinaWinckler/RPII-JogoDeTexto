using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

namespace  Catalogo {
    public class ItemDatabase : MonoBehaviour {

        public List<ItemJson> database = new List<ItemJson>();
        public JsonData itemData;

        private void Start() {
            itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/ItemJson.json"));
            ConstrucItemDatabase();

        }

        public ItemJson FetchItemByID(int id) {
            for (int i = 0; i < database.Count; i++)
                if (database[i].ID == id) {
                    return database[i];
                }

            return null;
        }
        void ConstrucItemDatabase() {
            for (int i = 0; i < itemData.Count; i++) {
                database.Add(new ItemJson((int) itemData[i]["id"], itemData[i]["nome"].ToString(),
                    itemData[i]["descricao"].ToString(), (int) itemData[i]["valor"], (bool) itemData[i]["stackable"],
                    itemData[i]["slug"].ToString()));
            }
        }
    }
}