using UnityEngine;

public class EventoForno : MonoBehaviour, EventController
{
    public EstadoForno estadoForno;
    public UI_ItemCollctor UI;

    public void doAction()
    {
        EstadoForno novoEstado = estadoForno.mudarDeEstado();

        if (novoEstado == estadoForno)
        {
            UI.mostrarErroAoInteragirComEvento();
        }

        estadoForno = novoEstado;
    }
}
