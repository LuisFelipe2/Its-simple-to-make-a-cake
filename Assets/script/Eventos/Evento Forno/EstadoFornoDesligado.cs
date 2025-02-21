using UnityEngine;

public class EstadoFornoDesligado : MonoBehaviour, EstadoForno
{
    private EventoButijao eventoButijao;
    private Inventario inventario;
    private GameController gameController;

    private void Start()
    {
        eventoButijao = FindObjectOfType<EventoButijao>();
        inventario = FindObjectOfType<Inventario>();
        gameController = FindObjectOfType<GameController>();
    }

    public EstadoForno mudarDeEstado()
    {

        if (inventario.getItem() != null && inventario.getItem().tag == "Fosforo")
        {
            if (eventoButijao.GetEstadoButijaoAtual() is EstadoButijaoNovo)
            {
                gameController.EndGame("Final Bom");
                return GetComponent<EstadoFornoLigado>();
            }
            else
            {
                gameController.EndGame("Final Ruim");
            }
        }

        return this;
    }
}
