using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorFinal : MonoBehaviour
{
    public GameObject painelMajor;
    public GameObject painelBolaDeNeve;
    public GameObject painelNapoleao;
    public GameObject painelEmpate;

    public void MostrarFinal()
    {
        FindFirstObjectByType<GerenciadorMissoes>().textoMissao.gameObject.SetActive(false);

        int major = GerenciadorEscolhas.instancia.pontosMajor;
        int bola = GerenciadorEscolhas.instancia.pontosBolaDeNeve;
        int napoleao = GerenciadorEscolhas.instancia.pontosNapoleao;

        if (major > bola && major > napoleao)
        {
            painelMajor.SetActive(true);
        }
        else if (bola > major && bola > napoleao)
        {
            painelBolaDeNeve.SetActive(true);
        }
        else if (napoleao > major && napoleao > bola)
        {
            painelNapoleao.SetActive(true);
        }
        else
        {
            painelEmpate.SetActive(true);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void VoltarMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}