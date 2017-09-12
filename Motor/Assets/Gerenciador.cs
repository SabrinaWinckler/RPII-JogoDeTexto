using System.Collections;
using System.Collections.Generic;
using UnityEngine.JsonUtility.FromJson;
using UnityEngine;
namespace Escolha
{
    [System.Serializable]
    class Gerenciador  
    {
        public string texto;
        public int id;
        public string ramificacao;
        public bool resposta;
        public string consequencia;

        public Gerenciador(int id, string ramificacao, string cena, string texto)
        {
            this.id = id;
            this.ramificacao = ramificacao;
            this.consequencia = cena;
            this.texto = texto;
                      
        }
        public Gerenciador()
        {
        }
        public Gerenciador(bool resposta)
        {
            this.resposta = resposta;
        }


        public static Gerenciador CreateFromJSON(string json)
        {
            return JsonUtility.FromJson<Gerenciador>(json);
        }

        
    }

}