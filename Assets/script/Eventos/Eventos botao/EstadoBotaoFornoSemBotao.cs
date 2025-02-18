using UnityEngine;

public class EstadoBotaoFornoSemBotao : MonoBehaviour, EstadoEventoBotão
{
    public int tempoDeAnimacaoEmMs = 3000;
    public CameraController cam;
    public Inventario inventario;

    public EstadoEventoBotão mudarDeEstado()
    {
        cam.FixCamera();

        if (inventario.getItem().tag == "Botão")
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
