using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class Fazendeiro : MonoBehaviour
{
    public Slider barraVida;

    public GameObject botaoFazendeiro;

    public TextMeshProUGUI textoVitoria;

    private int vida = 3;

    public void Atacar()
    {
        vida--;

        barraVida.value = vida;

        if (vida <= 0)
        {
            botaoFazendeiro.SetActive(false);

            textoVitoria.gameObject.SetActive(true);

            StartCoroutine(IrParaJogo());
        }
    }

    IEnumerator IrParaJogo()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("SampleScene");
    }
}