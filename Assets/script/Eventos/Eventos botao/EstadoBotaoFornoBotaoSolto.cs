using UnityEngine;

public class EstadoBotaoFornoBotaoSolto : MonoBehaviour, EstadoEventoBot�o
{
    public int tempoDeAnimacaoEmMs = 3000;
    public CameraController cam;

    public EstadoEventoBot�o mudarDeEstado()
    {
        Debug.Log("Anim de cair o bot�o");
        return new EstadoBotaoFornoSemBotao();
    }
}
