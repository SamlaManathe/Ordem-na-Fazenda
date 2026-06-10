using UnityEngine;
using TMPro;

public class DialogoNPC : MonoBehaviour
{
    public GameObject painelDialogo;
    public TextMeshProUGUI textoDialogo;
    public GameObject textoInteracao;

    public MoverMouse moverMouse;
    public GerenciadorMissoes gerenciadorMissoes;

    public int faseNecessaria = 1; // controle de ordem dos NPCs

    private bool jogadorPerto = false;
    private bool podeInteragir = false;
    private bool jaConversou = false;

    private bool emDialogo = false;

    void Update()
    {
        if (jaConversou) return;

        podeInteragir = (gerenciadorMissoes.numeroMissao == faseNecessaria);

        if (emDialogo)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                FecharDialogo();
            }

            return;
        }

        if (jogadorPerto && podeInteragir && Input.GetKeyDown(KeyCode.E))
        {
            AbrirDialogo();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            FecharDialogo();
        }
    }

    void AbrirDialogo()
    {
        emDialogo = true;

        painelDialogo.SetActive(true);
        textoInteracao.SetActive(false);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        moverMouse.podeOlhar = false;

    }

    public void FecharDialogo()
    {
        emDialogo = false;

        painelDialogo.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        moverMouse.podeOlhar = true;

        if (jogadorPerto && !jaConversou && podeInteragir)
            textoInteracao.SetActive(true);
    }

    public void FinalizarConversa()
    {
        if (jaConversou) return;

        jaConversou = true;
        emDialogo = false;

        painelDialogo.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        moverMouse.podeOlhar = true;

        textoInteracao.SetActive(false);

        gerenciadorMissoes.ProximaMissao();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        jogadorPerto = true;

        podeInteragir = (gerenciadorMissoes.numeroMissao == faseNecessaria);

        if (!jaConversou && podeInteragir)
        {
            textoInteracao.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        jogadorPerto = false;

        if (!emDialogo)
        {
            textoInteracao.SetActive(false);
        }
    }
}