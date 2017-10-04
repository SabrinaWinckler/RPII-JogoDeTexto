﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class ItemDatabase : MonoBehaviour {

    public List<ItemJson> database = new List<ItemJson>();
    public JsonData itemData;

    private void Start()
    {
        itemData = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/StreamingAssets/ItemJson.json"));
        ConstrucItemDatabase();

    }

    public ItemJson FetchItemByID(int id)
    {
        for (int i = 0; i < database.Count; i++)
            if (database[i].ID == id)
            {
                return database[i];
            }

        return null;
    }
    void ConstrucItemDatabase()
    {
        for (int i = 0; i < itemData.Count; i++)
        {
            database.Add(new ItemJson((int)itemData[i]["id"], itemData[i]["nome"].ToString(),
                itemData[i]["descricao"].ToString(), (int)itemData[i]["valor"], itemData[i]["slug"].ToString(),
                (bool)itemData[i]["stackable"]));
        }
    }
}

 public class ItemJson {
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Valor { get; set; }
    public string Slug { get; set; }
    public Sprite Sprite { get; set; }
    public bool Stackable { get; set; }

    

    public ItemJson(int id, string nome, string descricao, int valor, string slug, bool stackable)
    {
        this.ID = id;
        this.Nome = nome;
        this.Descricao = descricao;
        this.Valor = valor;
        this.Slug = slug;
        this.Sprite = Resources.Load<Sprite>("Sprites/Items/" + slug);
        this.Stackable = stackable;
    }

    public ItemJson()
    {
        this.ID = -1;
    }

}