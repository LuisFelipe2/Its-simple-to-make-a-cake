using UnityEngine;

public class EstadoFornoLigado : MonoBehaviour, EstadoForno
{
    private EstadoFornoDesligado estado;

    private void Start()
    {
        estado = GetComponent<EstadoFornoDesligado>();
    }

    public EstadoForno mudarDeEstado()
    {
        Debug.Log("Lógica para faltar luz.");
        return estado;
    }
}
