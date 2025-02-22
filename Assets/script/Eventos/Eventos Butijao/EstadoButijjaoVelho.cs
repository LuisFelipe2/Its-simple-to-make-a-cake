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
        if (inventario.getItem() == "FitaAdesiva")
        {
            return GetComponent<EstadoButijãoRemendado>();
        }

        if (inventario.getItem() == "CanoNovo")
        {
            return GetComponent<EstadoButijaoNovo>();
        }

        return this;
    }
}
