using UnityEngine;

public class UI_ItemCollctor : MonoBehaviour
{
    public void mostrarInventario(GameObject item)
    {
        Debug.Log("Anima��o do item indo para o invent�rio");
    }

    public void arremessarItem(Item item)
    {
        Debug.Log("Anima��o do item indo para o invent�rio");
    }

    public void mostrarEvento()
    {
        Debug.Log("Icone para bot�o de intera��o");
    }

    public void mostrarErroAoInteragirComEvento()
    {
        Debug.Log("Erro para intera��o equivocada");
    }

    public void mostrarEventoBotaoPreso()
    {
        Debug.Log("Bot�o est� preso");
    }
}
