using UnityEngine;

public class EstadoBotaoFornoComCola : MonoBehaviour, EstadoEventoBotão
{
    public CameraController cam;
    public Inventario inventario;

    public EstadoEventoBotão mudarDeEstado()
    {
        if (inventario.getItem() != null && inventario.getItem().tag == "Botão")
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
