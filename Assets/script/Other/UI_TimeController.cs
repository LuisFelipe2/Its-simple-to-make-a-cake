using UnityEngine;

public class UI_TimeController : MonoBehaviour
{
    public void MostarTempo(int time)
    {
        Debug.Log("UI exibe tempo de jogo");
    }

    public void TempoEsgotado()
    {
        Debug.Log("UI exibe tempo esgotado");
    }
}
