using UnityEngine;

public class EstadoButijãoRemendado : MonoBehaviour, EstadoButijao
{
    public Inventario inventario;

    void Start()
    {
        inventario = FindObjectOfType<Inventario>();
    }

    public EstadoButijao mudarDeEstado()
    {
        if (inventario.getItem() == "CanoNovo")
        {
            return new EstadoButijaoNovo();
        }

        return this;
    }
}
