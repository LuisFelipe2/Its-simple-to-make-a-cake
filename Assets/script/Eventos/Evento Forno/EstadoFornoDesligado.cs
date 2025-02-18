using UnityEngine;

public class EstadoFornoDesligado : MonoBehaviour, EstadoForno
{
    private EventoButijao eventoButijao;
    private Inventario inventario;

    private GameController gameController;

    public EstadoForno mudarDeEstado()
    {

        if (inventario.getItem().tag == "Fosforo")
        {
            if (eventoButijao.GetEstadoButijaoAtual().tag == "Novo")
            {
                return new EstadoFornoLigado();
            }
            else
            {
                gameController.EndGame("Final Ruim");
            }
        }

        return this;
    }
}
