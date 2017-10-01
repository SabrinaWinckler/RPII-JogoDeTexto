using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class ItemDatabase : MonoBehaviour {

    private List<ItemJson> database = new List<ItemJson>();
    private JsonData itemData;

    private void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/Items.json"));
        ConstrucItemDatabase();

    }

    void ConstrucItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new ItemJson((int)itemData[i]["id"], itemData[i]["nome"].ToString(), itemData[i]["Decricao"].ToString(), (int)itemData[i]["valor"]));
        }
    }
}

public class ItemJson
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Valor { get; set; }

    public ItemJson(int id, string nome, string descricao, int valor)
    {
        this.ID = id;
        this.Nome = nome;
        this.Descricao = descricao;
        this.Valor = valor;
    }

}