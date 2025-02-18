using UnityEngine;

public class EstadoButijjaoVelho : MonoBehaviour, EstadoButijao
{
    public Inventario inventario;

    public EstadoButijao mudarDeEstado()
    {
        if (inventario.getItem().tag == "FitaAdesiva")
        {
            return new EstadoButij�oRemendado();
        }

        if (inventario.getItem().tag == "CanoNovo")
        {
            return new EstadoButijaoNovo();
        }

        return this;
    }
}
