using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("HistoriaInicial");
    }

    public void Sair()
    {
        Application.Quit();
    }
}