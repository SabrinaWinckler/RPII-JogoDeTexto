using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using Escolha;

public class MainPlayer : MonoBehaviour
{
    [Serializable]
    public class Motor
    {

        void Start()
        {
            bool interacao = false;
            string text = File.ReadAllText(@"C:\Users\SABRINA\Documents\trabalho1\Motor\Assets\Gerenciador.json");
            Gerenciador.CreateFromJSON(text);
            //do
            //{
               
            //a partit do id texto é mostrado e depois do click é levado a uma nova cena. 
           // } while (!game.resposta);
        }

        void Update()
        {
            
            // e avança para o próximo objeto instanciado atraves do json 
        }
    }
}