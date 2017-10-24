////using System;
////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;
////using UnityEngine.UI;
////using UnityEngine.SceneManagement;

////namespace textgame
////{
////    public class Configuracao : MonoBehaviour
////    {
////        #region Instância dos objetos do Unity
////        #region Botões superiores direitos
////        [Header("Botões superiores direitos")]
////        public Button btn_fechar;
////        public Button btn_config;
////        #endregion

////        #region Cenas do jogo
////        [Space(20)]
////        [Header("Cenas do jogo")]
////        public string cena_jogo;
////        public string cena_principal;
////        public RectTransform cena_config;
////        #endregion

////        #region Configurações de resolução
////        [Space(20)]
////        [Header("Configurações de resolução")]
////        public Dropdown dp_resolucoes;
////        private Resolution[] resolucoesSuportadas;
////        #endregion

////        #region Configuração de audio
////        [Space(20)]
////        [Header("Configuração de audio")]
////        public Toggle toggle_audio;
////        public Slider slider_audio;
////        #endregion

////        #region Configurações de efeitos sonoros
////        [Space(20)]
////        [Header("Configurações de efeitos sonoros")]
////        public Toggle toggle_efeitos;
////        public Slider slider_efeitos;
////        #endregion

////        //esse codigo tá uma bosta
////        #region Configurações de musica
////        [Space(20)]
////        [Header("Configurações de musica")]
////        public Toggle toggle_musica;
////        public Slider slider_musica;
////        public AudioSource audio_musica;
////        #endregion

////        #region Botões de configurações
////        [Space(20)]
////        public Button btn_pronto_config;
////        public AudioClip fx_pronto_config;
////        public Button btn_restaurar_padrao;
////        #endregion

////        #region Configuração geral de áudio

////        private AudioSource audios;

////        #endregion

////        public Button iniciar;

////        #endregion

//<<<<<<< HEAD
////        void Awake()
////        {
////            audios = GetComponent<AudioSource>();
////        }
//=======
//        //void Awake()
//        //{
//        //    audios = GetComponent<AudioSource>();
//        //}
//>>>>>>> Rodrigo

////        //Use this for initialization

////        //void Start()
////        // {

////        //    resolucoesSuportadas = new Resolution[] { novaResolucao(1024, 576, 60), novaResolucao(1280, 720, 60) };

////        //    inserirResolucoes();


////        //    playerPrefs();


////        //    Cursor.visible = true;

////        //    Time.timeScale = 1;

////        //     #region Eventos dos objetos do UNITY
////        //     btn_fechar.onClick = new Button.ButtonClickedEvent();

////        //    btn_config.onClick = new Button.ButtonClickedEvent();

////        //    btn_pronto_config.onClick = new Button.ButtonClickedEvent();


////        //    dp_resolucoes.onValueChanged = new Dropdown.DropdownEvent();


////        //    toggle_audio.onValueChanged = new Toggle.ToggleEvent();

////        //    slider_audio.onValueChanged = new Slider.SliderEvent();


////        //    toggle_efeitos.onValueChanged = new Toggle.ToggleEvent();

////        // Update is called once per frame
////        //{
////        //    if (Input.GetKey(KeyCode.Escape))
////        //    {
////        //        Application.Quit();
////        //    }


////        //    toggle_musica.onValueChanged = new Toggle.ToggleEvent();

////        //    slider_musica.onValueChanged = new Slider.SliderEvent();

////        //     #endregion

////        // #region Chamar métodos a partir dos eventos dos objetos

////        //    btn_fechar.onClick.AddListener(() => fecharJogo());

////        // btn_config.onClick.AddListener(() => {
////        //         cena_config.gameObject.SetActive(true);
////        //         iniciar.gameObject.SetActive(false);
////        //     });

////        //     btn_pronto_config.onClick.AddListener(() => {
////        //         cena_config.gameObject.SetActive(false);
////        //         iniciar.gameObject.SetActive(true);
////        //         audios.PlayOneShot(fx_pronto_config, PlayerPrefs.GetFloat("AUDIO_EFEITO"));
////        //     });

////        //     dp_resolucoes.onValueChanged.AddListener(setResolucao);

////        //     toggle_audio.onValueChanged.AddListener(setAudioGeral);
////        //     slider_audio.onValueChanged.AddListener(setVolumeGeral);

////        //     toggle_efeitos.onValueChanged.AddListener(setAudioEfeitos);
////        //     slider_efeitos.onValueChanged.AddListener(setVolumeEfeitos);

////        //     toggle_musica.onValueChanged.AddListener(setAudioMusica);
////        //     slider_musica.onValueChanged.AddListener(setVolumeMusica);
////        //     #endregion

////        //     Debug.Log("Jogo inicializou");
////        // }

////        //Update is called once per frame
////        //        void Update()
////        //{
////        //    if (Input.GetKey(KeyCode.Escape))
////        //    {
////        //        Application.Quit();
////        //    }

////        //    //if (Input.GetKey(KeyCode.I))
////        //    //{
////        //    //    Debug.Log(personagem1.Nome);
////        //    //}
////        //}

////        //public void fecharJogo()
////        //{
////        //    Application.Quit();
////        //    Debug.Log("Fecho");
////        //}

////        //#region METODOS - Configuração de resolução
////        //private void inserirResolucoes()
////        //{
////        //    dp_resolucoes.options.Clear();
////        //    dp_resolucoes.options.Add(new Dropdown.OptionData() { text = "1024x576" });
////        //    dp_resolucoes.options.Add(new Dropdown.OptionData() { text = "1280x720" });
////        //}

////        //private Resolution novaResolucao(int width, int heigth, int refreshRate)
////        //{
////        //    Resolution res = new Resolution();

////        //    res.width = width;
////        //    res.height = heigth;
////        //    res.refreshRate = refreshRate;

////        //    return res;
////        //}

////        //private void setResolucao(int newres)
////        //{
////        //    PlayerPrefs.SetInt("RESOLUCAO", dp_resolucoes.value);
////        //    Screen.SetResolution(resolucoesSuportadas[newres].width, resolucoesSuportadas[newres].height, false);
////        //}
////        //#endregion

////        #region METODOS - Configuração de áudio
////        private void setAudioGeral(bool audio)
////        {
////            if (!audio)
////            {
////                slider_audio.interactable = false;
////                toggle_efeitos.interactable = false;
////                slider_efeitos.interactable = false;
////                toggle_musica.interactable = false;
////                slider_musica.interactable = false;

////                GetComponent<AudioSource>().enabled = false;
////                PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 0);
////            }
////            else
////            {
////                setAudioMusica(audio);
////                setAudioEfeitos(audio);

////                slider_audio.interactable = true;
////                toggle_efeitos.interactable = true;
////                slider_efeitos.interactable = true;
////                toggle_musica.interactable = true;
////                slider_musica.interactable = true;

////                GetComponent<AudioSource>().enabled = true;
////                PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 1);
////            }
////        }

////        //        if (PlayerPrefs.HasKey("AUDIO_MUSICA"))
////        //        {
////        //            setVolumeMusica(PlayerPrefs.GetFloat("AUDIO_MUSICA"));
////        //            slider_musica.value = PlayerPrefs.GetFloat("AUDIO_MUSICA");
////        //        }
////        //    }
////        //    #endregion
////        //}

////        void Update()
////        {
////            if (Input.GetKey(KeyCode.Escape))
////            {
////                Application.Quit();
////            }

////            //if (Input.GetKey(KeyCode.I))
////            //{
////            //    Debug.Log(personagem1.Nome);
////            //}
////        }

////        public void fecharJogo()
////        {
////            Application.Quit();
////            Debug.Log("Fecho");
////        }

////        #region METODOS - Configuração de resolução
////        private void inserirResolucoes()
////        {
////            dp_resolucoes.options.Clear();
////            dp_resolucoes.options.Add(new Dropdown.OptionData() { text = "1024x576" });
////            dp_resolucoes.options.Add(new Dropdown.OptionData() { text = "1280x720" });
////        }

////        private Resolution novaResolucao(int width, int heigth, int refreshRate)
////        {
////            Resolution res = new Resolution();

////            res.width = width;
////            res.height = heigth;
////            res.refreshRate = refreshRate;

////            return res;
////        }

////        private void setResolucao(int newres)
////        {
////            PlayerPrefs.SetInt("RESOLUCAO", dp_resolucoes.value);
////            Screen.SetResolution(resolucoesSuportadas[newres].width, resolucoesSuportadas[newres].height, false);
////        }
////        #endregion

////        #region METODOS - Configuração de áudio
////        //private void setAudioGeral(bool audio)
////        //{
////        //    if (!audio)
////        //    {
////        //        slider_audio.interactable = false;
////        //        toggle_efeitos.interactable = false;
////        //        slider_efeitos.interactable = false;
////        //        toggle_musica.interactable = false;
////        //        slider_musica.interactable = false;

////        //        GetComponent<AudioSource>().enabled = false;
////        //        PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 0);
////        //    }
////        //    else
////        //    {
////        //        setAudioMusica(audio);
////        //        setAudioEfeitos(audio);

////        //        slider_audio.interactable = true;
////        //        toggle_efeitos.interactable = true;
////        //        slider_efeitos.interactable = true;
////        //        toggle_musica.interactable = true;
////        //        slider_musica.interactable = true;

////        //        GetComponent<AudioSource>().enabled = true;
////        //        PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 1);
////        //    }
////        //}

////        private void setVolumeGeral(float audio)
////        {
////            AudioListener.volume = audio;
////            PlayerPrefs.SetFloat("AUDIO_GERAL", audio);
////        }


////        private void setAudioEfeitos(bool audio)
////        {
////            if (!audio)
////            {
////                setVolumeEfeitos(0);
////                toggle_efeitos.isOn = false;
////                slider_efeitos.interactable = false;
////                PlayerPrefs.SetInt("AUDIO_EFEITO_ATIVADO", 0);
////            }
////            else
////            {
////                setVolumeEfeitos(slider_efeitos.value);
////                toggle_efeitos.isOn = true;
////                slider_efeitos.interactable = true;
////                PlayerPrefs.SetInt("AUDIO_EFEITO_ATIVADO", 1);
////            }
////        }

////        private void setVolumeEfeitos(float audio)
////        {
////            PlayerPrefs.SetFloat("AUDIO_EFEITO", audio);
////        }


////        private void setAudioMusica(bool audio)
////        {
////            if (!audio)
////            {
////                audio_musica.volume = 0;
////                toggle_musica.isOn = false;
////                slider_musica.interactable = false;
////                PlayerPrefs.SetInt("AUDIO_MUSICA_ATIVADO", 0);
////            }
////            else
////            {
////                audio_musica.volume = slider_musica.value;
////                toggle_musica.isOn = true;
////                slider_musica.interactable = true;
////                PlayerPrefs.SetInt("AUDIO_MUSICA_ATIVADO", 1);
////            }
////        }

////        private void setVolumeMusica(float audio)
////        {
////            audio_musica.volume = audio;
////            PlayerPrefs.SetFloat("AUDIO_MUSICA", audio);
////        }
////        #endregion

////        #region METODOS - Configuração de preferências
////        private void playerPrefs()
////        {
////            if (PlayerPrefs.HasKey("RESOLUCAO"))
////            {
////                dp_resolucoes.value = PlayerPrefs.GetInt("RESOLUCAO");


////                if (PlayerPrefs.GetInt("RESOLUCAO") == 0)
////                {
////                    dp_resolucoes.captionText.text = "1024x576";
////                }
////                else
////                {
////                    dp_resolucoes.captionText.text = "1280x720";
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_GERAL_ATIVADO"))
////            {
////                if (PlayerPrefs.GetInt("AUDIO_GERAL_ATIVADO") == 0)
////                {
////                    setAudioGeral(false);
////                    toggle_audio.isOn = false;
////                }
////                else
////                {
////                    setAudioGeral(true);
////                    toggle_audio.isOn = true;
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_GERAL"))
////            {
////                AudioListener.volume = PlayerPrefs.GetFloat("AUDIO_GERAL");
////                slider_audio.value = PlayerPrefs.GetFloat("AUDIO_GERAL");
////            }

////            if (PlayerPrefs.HasKey("AUDIO_EFEITO_ATIVADO"))
////            {
////                if (PlayerPrefs.GetInt("AUDIO_EFEITO_ATIVADO") == 0)
////                {
////                    setAudioEfeitos(false);
////                    toggle_efeitos.isOn = false;
////                }
////                else
////                {
////                    setAudioEfeitos(true);
////                    toggle_efeitos.isOn = true;
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_EFEITO"))
////            {
////                setVolumeEfeitos(PlayerPrefs.GetFloat("AUDIO_EFEITO"));
////                slider_efeitos.value = PlayerPrefs.GetFloat("AUDIO_EFEITO");
////            }

////            if (PlayerPrefs.HasKey("AUDIO_MUSICA_ATIVADO"))
////            {
////                if (PlayerPrefs.GetInt("AUDIO_MUSICA_ATIVADO") == 0)
////                {
////                    setAudioMusica(false);
////                    toggle_musica.isOn = false;
////                }
////                else
////                {
////                    setAudioMusica(true);
////                    toggle_musica.isOn = true;
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_MUSICA"))
////            {
////                setVolumeMusica(PlayerPrefs.GetFloat("AUDIO_MUSICA"));
////                slider_musica.value = PlayerPrefs.GetFloat("AUDIO_MUSICA");
////            }

////        }
////    }
////}
////}
//<<<<<<< HEAD
////}
//=======
////#endregion

////#region METODOS - Configuração de áudio
////private void setAudioGeral(bool audio)
////{
////    if (!audio)
////    {
////        slider_audio.interactable = false;
////        toggle_efeitos.interactable = false;
////        slider_efeitos.interactable = false;
////        toggle_musica.interactable = false;
////        slider_musica.interactable = false;

////        GetComponent<AudioSource>().enabled = false;
////        PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 0);
////    }
////    else
////    {
////        setAudioMusica(audio);
////        setAudioEfeitos(audio);

////        slider_audio.interactable = true;
////        toggle_efeitos.interactable = true;
////        slider_efeitos.interactable = true;
////        toggle_musica.interactable = true;
////        slider_musica.interactable = true;

////        GetComponent<AudioSource>().enabled = true;
////        PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 1);
////    }
////}

////    //        if (PlayerPrefs.HasKey("AUDIO_MUSICA"))
////    //        {
////    //            setVolumeMusica(PlayerPrefs.GetFloat("AUDIO_MUSICA"));
////    //            slider_musica.value = PlayerPrefs.GetFloat("AUDIO_MUSICA");
////    //        }
////    //    }
////    //    #endregion
////    //}
////=======
////        void Update()
////        {
////            if (Input.GetKey(KeyCode.Escape))
////            {
////                Application.Quit();
////            }

////            //if (Input.GetKey(KeyCode.I))
////            //{
////            //    Debug.Log(personagem1.Nome);
////            //}
////        }

////        public void fecharJogo()
////        {
////            Application.Quit();
////            Debug.Log("Fecho");
////        }

////        #region METODOS - Configuração de resolução
////        private void inserirResolucoes()
////        {
////            dp_resolucoes.options.Clear();
////            dp_resolucoes.options.Add(new Dropdown.OptionData() { text = "1024x576" });
////            dp_resolucoes.options.Add(new Dropdown.OptionData() { text = "1280x720" });
////        }

////        private Resolution novaResolucao(int width, int heigth, int refreshRate)
////        {
////            Resolution res = new Resolution();

////            res.width = width;
////            res.height = heigth;
////            res.refreshRate = refreshRate;

////            return res;
////        }

////        private void setResolucao(int newres)
////        {
////            PlayerPrefs.SetInt("RESOLUCAO", dp_resolucoes.value);
////            Screen.SetResolution(resolucoesSuportadas[newres].width, resolucoesSuportadas[newres].height, false);
////        }
////        #endregion

////        #region METODOS - Configuração de áudio
////        private void setAudioGeral(bool audio)
////        {
////            if (!audio)
////            {
////                slider_audio.interactable = false;
////                toggle_efeitos.interactable = false;
////                slider_efeitos.interactable = false;
////                toggle_musica.interactable = false;
////                slider_musica.interactable = false;

////                GetComponent<AudioSource>().enabled = false;
////                PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 0);
////            }
////            else
////            {
////                setAudioMusica(audio);
////                setAudioEfeitos(audio);

////                slider_audio.interactable = true;
////                toggle_efeitos.interactable = true;
////                slider_efeitos.interactable = true;
////                toggle_musica.interactable = true;
////                slider_musica.interactable = true;

////                GetComponent<AudioSource>().enabled = true;
////                PlayerPrefs.SetInt("AUDIO_GERAL_ATIVADO", 1);
////            }
////        }

////        private void setVolumeGeral(float audio)
////        {
////            AudioListener.volume = audio;
////            PlayerPrefs.SetFloat("AUDIO_GERAL", audio);
////        }


////        private void setAudioEfeitos(bool audio)
////        {
////            if (!audio)
////            {
////                setVolumeEfeitos(0);
////                toggle_efeitos.isOn = false;
////                slider_efeitos.interactable = false;
////                PlayerPrefs.SetInt("AUDIO_EFEITO_ATIVADO", 0);
////            }
////            else
////            {
////                setVolumeEfeitos(slider_efeitos.value);
////                toggle_efeitos.isOn = true;
////                slider_efeitos.interactable = true;
////                PlayerPrefs.SetInt("AUDIO_EFEITO_ATIVADO", 1);
////            }
////        }

////        private void setVolumeEfeitos(float audio)
////        {
////            PlayerPrefs.SetFloat("AUDIO_EFEITO", audio);
////        }


////        private void setAudioMusica(bool audio)
////        {
////            if (!audio)
////            {
////                audio_musica.volume = 0;
////                toggle_musica.isOn = false;
////                slider_musica.interactable = false;
////                PlayerPrefs.SetInt("AUDIO_MUSICA_ATIVADO", 0);
////            }
////            else
////            {
////                audio_musica.volume = slider_musica.value;
////                toggle_musica.isOn = true;
////                slider_musica.interactable = true;
////                PlayerPrefs.SetInt("AUDIO_MUSICA_ATIVADO", 1);
////            }
////        }

////        private void setVolumeMusica(float audio)
////        {
////            audio_musica.volume = audio;
////            PlayerPrefs.SetFloat("AUDIO_MUSICA", audio);
////        }
////        #endregion

////        #region METODOS - Configuração de preferências
////        private void playerPrefs()
////        {
////            if (PlayerPrefs.HasKey("RESOLUCAO"))
////            {
////                dp_resolucoes.value = PlayerPrefs.GetInt("RESOLUCAO");


////                if (PlayerPrefs.GetInt("RESOLUCAO") == 0)
////                {
////                    dp_resolucoes.captionText.text = "1024x576";
////                }
////                else
////                {
////                    dp_resolucoes.captionText.text = "1280x720";
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_GERAL_ATIVADO"))
////            {
////                if (PlayerPrefs.GetInt("AUDIO_GERAL_ATIVADO") == 0)
////                {
////                    setAudioGeral(false);
////                    toggle_audio.isOn = false;
////                }
////                else
////                {
////                    setAudioGeral(true);
////                    toggle_audio.isOn = true;
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_GERAL"))
////            {
////                AudioListener.volume = PlayerPrefs.GetFloat("AUDIO_GERAL");
////                slider_audio.value = PlayerPrefs.GetFloat("AUDIO_GERAL");
////            }

////            if (PlayerPrefs.HasKey("AUDIO_EFEITO_ATIVADO"))
////            {
////                if (PlayerPrefs.GetInt("AUDIO_EFEITO_ATIVADO") == 0)
////                {
////                    setAudioEfeitos(false);
////                    toggle_efeitos.isOn = false;
////                }
////                else
////                {
////                    setAudioEfeitos(true);
////                    toggle_efeitos.isOn = true;
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_EFEITO"))
////            {
////                setVolumeEfeitos(PlayerPrefs.GetFloat("AUDIO_EFEITO"));
////                slider_efeitos.value = PlayerPrefs.GetFloat("AUDIO_EFEITO");
////            }

////            if (PlayerPrefs.HasKey("AUDIO_MUSICA_ATIVADO"))
////            {
////                if (PlayerPrefs.GetInt("AUDIO_MUSICA_ATIVADO") == 0)
////                {
////                    setAudioMusica(false);
////                    toggle_musica.isOn = false;
////                }
////                else
////                {
////                    setAudioMusica(true);
////                    toggle_musica.isOn = true;
////                }
////            }

////            if (PlayerPrefs.HasKey("AUDIO_MUSICA"))
////            {
////                setVolumeMusica(PlayerPrefs.GetFloat("AUDIO_MUSICA"));
////                slider_musica.value = PlayerPrefs.GetFloat("AUDIO_MUSICA");
////            }
////        }
////        #endregion
//    }
//}
//>>>>>>> Rodrigo
