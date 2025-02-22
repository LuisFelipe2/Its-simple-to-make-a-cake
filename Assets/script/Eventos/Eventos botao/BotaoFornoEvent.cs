using UnityEngine;

public class BotaoFornoEvent : MonoBehaviour, EventController
{
    private EstadoEventoBotão estadoAtual;
    private UI_ItemCollctor UI;

    private void Start()
    {
        UI = FindObjectOfType<UI_ItemCollctor>();
        estadoAtual = GetComponent<EstadoBotaoFornoBotaoSolto>();
    }

    public void doAction()
    {
        Debug.Log("Evento Botao:" + estadoAtual);
        EstadoEventoBotão novoEstado = estadoAtual.mudarDeEstado();

        if (novoEstado is EstadoBotaoFornoBotaoPreso)
        {
            UI.mostrarEventoBotaoPreso();
        }
        else if (novoEstado == estadoAtual)
        {
            UI.mostrarErroAoInteragirComEvento();
        }

        estadoAtual = novoEstado;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
