using UnityEngine;
using UnityEngine.SceneManagement;

public class HistoriaInicial : MonoBehaviour
{
    public GameObject painel1;
    public GameObject painel2;
    public GameObject painel3;

    private int pagina = 1;

    public void Proximo()
    {
        if (pagina == 1)
        {
            painel1.SetActive(false);
            painel2.SetActive(true);
            pagina++;
        }
        else if (pagina == 2)
        {
            painel2.SetActive(false);
            painel3.SetActive(true);
            pagina++;
        }
        else
        {
            SceneManager.LoadScene("LutaFazendeiro");
        }
    }
}