using UnityEngine;

public class EstadoBotaoFornoComCola : MonoBehaviour, EstadoEventoBot�o
{
    public CameraController cam;
    public Inventario inventario;

    public EstadoEventoBot�o mudarDeEstado()
    {
        cam.FixCamera();

        if (inventario.getItem().tag == "Bot�o")
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
