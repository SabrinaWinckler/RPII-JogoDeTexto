using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

namespace textgame
{
    class Personagem
    {

        public float saldo;
        public int posicao_vetor;
        public Profissao[] profissoes = new Profissao[6];
        public String nome_profissao;
        public Text text_img_Avatar;
        public Canvas img_Avatar;

        public Personagem() {
            Profissao medico = new Profissao("Medico", 300f);
            profissoes[0] = medico;
            Profissao advogado = new Profissao("Advogado", 300f);
            profissoes[1] = advogado;
            Profissao policial = new Profissao("Policial", 200f);
            profissoes[2] = policial;
            Profissao atleta = new Profissao("Atleta", 100f);
            profissoes[3] = atleta;

            Saldo = 0.0f;
        }

        public float Saldo {
            get {return saldo; }
            set {saldo = value; }
        }

        public String Nome_profissao {
            get { return nome_profissao; }
            set { nome_profissao = value; }
        }

        public Profissao GetProfissao() {
            for (int i = 0; i < profissoes.Length; i++) {
                if (profissoes[i] != null) {
                    if (profissoes[i].Nome.Equals(Nome_profissao, StringComparison.OrdinalIgnoreCase)) {
                        this.posicao_vetor = i;
                        //RETORNA O OBJETO PROFISSAO COM TODOS SEUS ATRIBUTOS/MÉTODOS
                        return profissoes[i];
                    }
                }
            }

            //RETORNA NULO SE NÃO ENCONTRAR A PROFISSAO PELA STRING
            return null;
        }

        public void AtualizaSaldo() {
            //ATUALIZA SALDO COM ACRÉSCIMO DO BONUS DE CADA PROFISSÃO
            Saldo += profissoes[posicao_vetor].Bonus;
        }

        public void MostrarAvatar(String person) {

            text_img_Avatar.text = person;

            WWW avatarPersonagem = new WWW(Path.Combine(Application.streamingAssetsPath, "Img_Personagem/" + person));
            img_Avatar.GetComponent<RawImage>().texture = avatarPersonagem.texture;
        }
    }
}
