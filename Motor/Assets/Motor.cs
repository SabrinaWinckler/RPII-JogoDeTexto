using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using Escolha;

public class MainPlayer : MonoBehaviour
{
    [Serializable]
    public class Motor
    {

        void Start()
        {
            Gerenciador game = new Gerenciador();
            string text = System.IO.File.ReadAllText(@"C:\Users\SABRINA\Documents\trabalho1\Motor\Assets\caminhos.json");
            Gerenciador.CreateFromJSON(text);
            //do
            //{
                System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
            //a partit do id texto é mostrado e depois do click é levado a uma nova cena. 
           // } while (!game.resposta);
        }

        void Update()
        {
            game.resposta = false;
            // e avança para o próximo objeto instanciado atraves do json 
        }
    }
}