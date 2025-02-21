using UnityEngine;

public class EstadoBotaoFornoBotaoSolto : MonoBehaviour, EstadoEventoBotão
{
    public int tempoDeAnimacaoEmMs = 3000;
    public CameraController cam;

    public EstadoEventoBotão mudarDeEstado()
    {
        Debug.Log("Anim de cair o botão");
        return new EstadoBotaoFornoSemBotao();
    }
}
