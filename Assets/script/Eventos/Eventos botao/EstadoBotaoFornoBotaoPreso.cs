using UnityEngine;

public class EstadoBotaoFornoBotaoPreso : MonoBehaviour, EstadoEventoBotão
{
    public EstadoEventoBotão mudarDeEstado()
    {
        return this;
    }
}
