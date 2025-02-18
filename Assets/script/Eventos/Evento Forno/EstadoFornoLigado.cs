using UnityEngine;

public class EstadoFornoLigado : MonoBehaviour, EstadoForno
{
    public EstadoForno mudarDeEstado()
    {
        return new EstadoFornoDesligado();
    }
}
