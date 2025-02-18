using UnityEngine;

public class EstadoButijãoRemendado : MonoBehaviour, EstadoButijao
{
    public Inventario inventario;

    public EstadoButijao mudarDeEstado()
    {
        if (inventario.getItem().tag == "CanoNovo")
        {
            return new EstadoButijaoNovo();
        }

        return this;
    }
}
