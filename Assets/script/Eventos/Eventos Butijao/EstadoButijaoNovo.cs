using UnityEngine;

public class EstadoButijaoNovo : MonoBehaviour, EstadoButijao
{
    public EstadoButijao mudarDeEstado()
    {
        return this;
    }
}
