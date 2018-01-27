using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe responsável para listar efeitos sonoros do jogo e que permite que eles sejam tocados.
/// </summary>
public class EfeitosSonoros : MonoBehaviour {

    #region Configuração de Simpleton
    private static EfeitosSonoros instancia;

    public static EfeitosSonoros Instancia
    {
        get { return instancia; }
    }

    public EfeitosSonoros()
    {
        if (instancia == null) instancia = this;
    }
    #endregion

    private static Dictionary<string, AudioSource> dicionario_de_efeitos_sonoros;

    #region Lista de Efeitos Sonoros
    public AudioClip barulho_de_dano_1;
    AudioSource a_s_barulho_de_dano_1;

    public AudioClip pensar_nos_amigos;
    AudioSource a_s_pensar_nos_amigos;

    public AudioClip levantando;
    AudioSource a_s_levantando;

    public AudioClip dormindo;
    AudioSource a_s_dormindo;

    public AudioClip sair_da_cama;
    AudioSource a_s_sair_da_cama;

    public AudioClip travesseiro;
    AudioSource a_s_travesseiro;

    public AudioClip edredon;
    AudioSource a_s_edredon;

    public AudioClip colchao;
    AudioSource a_s_colchao;
    #endregion

    #region Funções de Tocar Som
    static public void TocarSom(string nome, float volume)
    {
        AudioSource som = dicionario_de_efeitos_sonoros[nome];
        if (som != null)
        {
            som.PlayOneShot(som.clip, volume);
        }
    }

    static public void TocarSom(string nome)
    {
        TocarSom(nome, ControleDeVolumes.volume_de_efeitos_sonoros);
    }

    static public void TocarSomDeInterface(string nome)
    {
        TocarSom(nome, ControleDeVolumes.volume_de_efeitos_de_interface_grafica);
    }
    #endregion


    // Use this for initialization
    void Start () {
        Inicializacao();
    }

    // Update is called once per frame
    void Update () {

    }

    void Inicializacao()
    {
        //Criação do dicionário
        dicionario_de_efeitos_sonoros = new Dictionary<string, AudioSource>(32);

        //Criação dos AudioSources e adição à dicionário
        a_s_barulho_de_dano_1 = gameObject.AddComponent<AudioSource>();
        a_s_barulho_de_dano_1.clip = barulho_de_dano_1;
        dicionario_de_efeitos_sonoros.Add("Barulho de Dano 1", a_s_barulho_de_dano_1);

        a_s_pensar_nos_amigos = gameObject.AddComponent<AudioSource>();
        a_s_pensar_nos_amigos.clip = pensar_nos_amigos;
        dicionario_de_efeitos_sonoros.Add("Pensar nos Amigos", a_s_pensar_nos_amigos);

        a_s_levantando = gameObject.AddComponent<AudioSource>();
        a_s_levantando.clip = levantando;
        dicionario_de_efeitos_sonoros.Add("Levantando", a_s_levantando);

        a_s_dormindo = gameObject.AddComponent<AudioSource>();
        a_s_dormindo.clip = dormindo;
        dicionario_de_efeitos_sonoros.Add("Dormindo", a_s_dormindo);

        a_s_sair_da_cama = gameObject.AddComponent<AudioSource>();
        a_s_sair_da_cama.clip = sair_da_cama;
        dicionario_de_efeitos_sonoros.Add("Sair da Cama", a_s_sair_da_cama);

        a_s_travesseiro = gameObject.AddComponent<AudioSource>();
        a_s_travesseiro.clip = travesseiro;
        dicionario_de_efeitos_sonoros.Add("Travesseiro", a_s_travesseiro);

        a_s_edredon = gameObject.AddComponent<AudioSource>();
        a_s_edredon.clip = edredon;
        dicionario_de_efeitos_sonoros.Add("Edredon", a_s_edredon);

        a_s_colchao = gameObject.AddComponent<AudioSource>();
        a_s_colchao.clip = colchao;
        dicionario_de_efeitos_sonoros.Add("Colchão", a_s_colchao);
    }
}
