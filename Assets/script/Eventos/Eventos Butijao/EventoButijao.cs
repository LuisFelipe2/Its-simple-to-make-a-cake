using UnityEngine;

public class EventoButijao : MonoBehaviour, EventController
{
    public EstadoButijao estadoButijaoAtual;

    public UI_ItemCollctor UI;

    private void Start()
    {
        estadoButijaoAtual = GetComponent<EstadoButijjaoVelho>();
        UI = FindObjectOfType<UI_ItemCollctor>();
    }

    public void doAction()
    {
        EstadoButijao novoEstado = estadoButijaoAtual.mudarDeEstado();

        if (novoEstado == estadoButijaoAtual)
        {
            UI.mostrarErroAoInteragirComEvento();
        }

        estadoButijaoAtual = novoEstado;
    }

    public EstadoButijao GetEstadoButijaoAtual()
    {

        return estadoButijaoAtual;

    }
}