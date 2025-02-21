using UnityEngine;

public class EstadoButijjaoVelho : MonoBehaviour, EstadoButijao
{
    public Inventario inventario;

    private void Start()
    {
        inventario = FindObjectOfType<Inventario>();
    }

    public EstadoButijao mudarDeEstado()
    {
        if (inventario.getItem() != null && inventario.getItem().tag == "FitaAdesiva")
        {
            return GetComponent<EstadoButijãoRemendado>();
        }

        if (inventario.getItem() != null && inventario.getItem().tag == "CanoNovo")
        {
            return GetComponent<EstadoButijaoNovo>();
        }

        return this;
    }
}
