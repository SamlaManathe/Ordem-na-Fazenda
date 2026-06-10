using UnityEngine;
using TMPro;

public class GerenciadorEscolhas : MonoBehaviour
{
    public static GerenciadorEscolhas instancia;

    public TextMeshProUGUI textoEscolhas;

    public int pontosMajor = 0;
    public int pontosBolaDeNeve = 0;
    public int pontosNapoleao = 0;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        AtualizarTexto();
    }

    public void EscolhaMajor()
    {
        pontosMajor++;
        AtualizarTexto();
    }

    public void EscolhaBolaDeNeve()
    {
        pontosBolaDeNeve++;
        AtualizarTexto();
    }

    public void EscolhaNapoleao()
    {
        pontosNapoleao++;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        if (textoEscolhas == null) return;

        textoEscolhas.text =
            "Major: " + pontosMajor +
            "\nBola de Neve: " + pontosBolaDeNeve +
            "\nNapoleão: " + pontosNapoleao;
    }
}