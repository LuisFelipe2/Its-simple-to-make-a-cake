using UnityEngine;

public class EstadoBotaoFornoSemBotao : MonoBehaviour, EstadoEventoBotão
{
    public int tempoDeAnimacaoEmMs = 3000;
    public CameraController cam;
    public Inventario inventario;

    void Start()
    {
        inventario = FindFirstObjectByType<Inventario>();
        cam = FindFirstObjectByType<CameraController>();
    }

    public EstadoEventoBotão mudarDeEstado()
    {
        if (inventario.getItem() != null && inventario.getItem().tag == "Botão")
        {
            return new EstadoBotaoFornoBotaoSolto();
        }
        else if (inventario.getItem() != null && inventario.getItem().tag == "Cola")
        {
            return new EstadoBotaoFornoComCola();
        }

        return this;
    }
}
