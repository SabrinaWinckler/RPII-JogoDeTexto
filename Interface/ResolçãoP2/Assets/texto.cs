using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class texto : MonoBehaviour {

    public Button continuar;
    public Text otexto;
    public RawImage canvas;

	// Use this for initialization
	void Start () {

        continuar.onClick = new Button.ButtonClickedEvent();

        continuar.onClick.AddListener(() => novotexto());
		
	}

    private void novotexto()
    {
        otexto.text = "Você está escorado na sua mesa, com o copo de whisky na mão, encarando a placa com seu nome ao lado da sua mão. Você sente a nostalgia que não existe. Você ri internamente compreendendo que uma das suas felicidades nesta vida é esses momentos que você sente uma nostalgia inexistente, vivendo um arquétipo do que seria uma profissão romantizada. Você está tranquilo, pois você já resolveu 4 casos esse mês, pagou todas suas dívidas de aluguel e gastos, re-estocou a dispensa com o necessário e sobrou dinheiro o suficiente para você dar um jeito de passar o próximo mês. É sempre assim, vivendo mês após mês. Apesar de ter entrado neste ramo de trabalho por motivos “glorificados” você é muito bom no que faz e ganhou um razoável reconhecimento na área nestes 6 anos que atua como investigador privado. Você até solucionou alguns crimes que acabou tropeçando enquanto trabalhava em um caso.Por isso não foi surpresa quando a silhueta na sua porta apareceu aquela hora(você mandou trocar a porta de madeira inteiriça do escritório por uma que é metade de vidro embaçado, com seu nome e profissão no meio). A cena é típica de um romance e você sente a mesma adrenalina de estar vivendo um conto de mistério, uma sensação que é segredo para o resto do mundo.Mesmo depois de tantos anos você ainda sente a mesma coisa quando acontece. A sombra bate na porta e você percebe que é uma mulher. A luz do corredor está fraca, impedindo você de deduzir características de clientes de dentro do escritório.Você pensa em mandar trocar a lâmpada. Alguém está na porta. O que você faz?";
    }

    // Update is called once per frame
    void Update () {
		
	}
}
