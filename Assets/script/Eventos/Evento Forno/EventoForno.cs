using UnityEngine;

public class EventoForno : MonoBehaviour, EventController
{
    public EstadoForno estadoForno;
    public UI_ItemCollctor UI;

    private void Start()
    {
        estadoForno = FindObjectOfType<EstadoFornoLigado>();
        UI = FindObjectOfType<UI_ItemCollctor>();
    }

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
