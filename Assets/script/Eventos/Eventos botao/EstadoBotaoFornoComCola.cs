using UnityEngine;

public class EstadoBotaoFornoComCola : MonoBehaviour, EstadoEventoBot�o
{
    public CameraController cam;
    public Inventario inventario;

    public EstadoEventoBot�o mudarDeEstado()
    {
        if (inventario.getItem() == "Bot�o")
        {
            return new EstadoBotaoFornoBotaoSolto();
        }

        return this;
    }

    private void Start()
    {
        cam = FindFirstObjectByType<CameraController>();
        inventario = FindFirstObjectByType<Inventario>();
    }
}
