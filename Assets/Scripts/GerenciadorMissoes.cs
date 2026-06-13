using TMPro;
using UnityEngine;

public class GerenciadorMissoes : MonoBehaviour
{
    public static GerenciadorMissoes instancia;

    public TextMeshProUGUI textoMissao;

    public int numeroMissao = 1;
    private int progresso = 0;
    private int objetivo = 16;

    void Awake()
    {
        instancia = this;
    }

    void Start()
    {
        AtualizarTexto();
    }

    public void ProximaMissao()
    {
        numeroMissao++;
        progresso = 0;

        AtualizarTexto();
    }

    public void ColetouMaca()
    {
        if (numeroMissao == 2)
        {
            progresso++;
            VerificarMissao();
        }
    }

    public void ColetouVegetal(string tipo)
    {
        if (numeroMissao == 4 && tipo == "Cenoura") progresso++;
        if (numeroMissao == 6 && tipo == "Trigo") progresso++;
        if (numeroMissao == 8 && tipo == "Melancia") progresso++;
        if (numeroMissao == 10 && tipo == "Beterraba") progresso++;

        VerificarMissao();
    }

    void VerificarMissao()
    {
        if (progresso >= objetivo)
        {
            numeroMissao++;
            progresso = 0;

            if (numeroMissao > 10)
            {
                FindFirstObjectByType<GerenciadorFinal>().MostrarFinal();
                return;
            }
        }

        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        switch (numeroMissao)
        {
            case 1:
                textoMissao.text = "Converse com a vaca no lago";
                break;

            case 2:
                textoMissao.text = "Colete 16 maçãs caídas\n" + progresso + "/16";
                break;

            case 3:
                textoMissao.text = "Converse com o cachorro no galinheiro";
                break;

            case 4:
                textoMissao.text = "Colete 16 cenouras na plantação\n" + progresso + "/16";
                break;

            case 5:
                textoMissao.text = "Converse com o cavalo no celeiro";
                break;

            case 6:
                textoMissao.text = "Colete 16 trigos na plantação\n" + progresso + "/16";
                break;

            case 7:
                textoMissao.text = "Converse com a ovelha na plantação";
                break;

            case 8:
                textoMissao.text = "Colete 16 melancias na plantação\n" + progresso + "/16";
                break;

            case 9:
                textoMissao.text = "Converse com o porco atrás da casa";
                break;

            case 10:
                textoMissao.text = "Colete 16 beterrabas na plantação\n" + progresso + "/16";
                break;

            default:
                textoMissao.text = "Fim do jogo!";
                break;
        }
    }
}