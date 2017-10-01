using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IA : MonoBehaviour {

    private string frase;
    public InputField texto_entrada; 

    // Use this for initialization
    void Start () {

        frase = "Teste";
		
	}
	
	// Update is called once per frame
	void Update () {
        if (texto_entrada.text.Contains("Test")) {
            Debug.Log("Ok");
        }
	}
}
