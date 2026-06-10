using System.Collections;
using UnityEngine;

public class Plantacao : MonoBehaviour
{
    public float tempoParaCrescer = 60f;

    public string tipoVegetal;

    private Renderer rend;
    private Collider col;
    private bool podeColher = true;

    void Start()
    {
        rend = GetComponent<Renderer>();
        col = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && podeColher)
        {
            podeColher = false;

            GerenciadorMissoes.instancia.ColetouVegetal(tipoVegetal);

            rend.enabled = false;
            col.enabled = false;

            StartCoroutine(CrescerNovamente());
        }
    }

    IEnumerator CrescerNovamente()
    {
        yield return new WaitForSeconds(tempoParaCrescer);

        rend.enabled = true;
        col.enabled = true;

        podeColher = true;
    }
}