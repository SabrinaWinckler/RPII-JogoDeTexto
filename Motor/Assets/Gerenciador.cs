using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Escolha
{
    [System.Serializable]
    class Gerenciador  
    {
        List<Cenarios> cenarios;

        public Gerenciador()
        {
        }


        public static Gerenciador CreateFromJSON(string json)
        {
            return JsonUtility.FromJson<Gerenciador>(json);
        }

        
    }

    
}