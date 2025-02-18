using UnityEngine;

public class EstadoBotaoFornoSemBotao : MonoBehaviour, EstadoEventoBot�o
{
    public int tempoDeAnimacaoEmMs = 3000;
    public CameraController cam;
    public Inventario inventario;

    public EstadoEventoBot�o mudarDeEstado()
    {
        cam.FixCamera();

        if (inventario.getItem().tag == "Bot�o")
        {
            return new EstadoBotaoFornoBotaoSolto();
        }
        else if (inventario.getItem().tag == "Cola")
        {
            return new EstadoBotaoFornoComCola();
        }

        return this;
    }

    private void Start()
    {
        cam = FindFirstObjectByType<CameraController>();
        inventario = FindFirstObjectByType<Inventario>();
    }
}
