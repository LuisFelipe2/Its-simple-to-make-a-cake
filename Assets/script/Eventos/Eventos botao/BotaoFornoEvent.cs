using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoFornoEvent : MonoBehaviour, EventController
{
    public EstadoEventoBotão estadoAtual;
    public UI_ItemCollctor UI;

    public void doAction()
    {
        EstadoEventoBotão novoEstado = estadoAtual.mudarDeEstado();

        if (novoEstado == new EstadoBotaoFornoBotaoPreso())
        {
            UI.mostrarEventoBotaoPreso();
        } else if (novoEstado == estadoAtual) {
            UI.mostrarErroAoInteragirComEvento();
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
