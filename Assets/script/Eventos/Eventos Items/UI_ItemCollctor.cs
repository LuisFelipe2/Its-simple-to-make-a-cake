using UnityEngine;

public class UI_ItemCollctor : MonoBehaviour
{
    public void mostrarInventario(GameObject item)
    {
        Debug.Log("Animação do item indo para o inventário");
    }

    public void arremessarItem(Item item)
    {
        Debug.Log("Animação do item indo para o inventário");
    }

    public void mostrarEvento()
    {
        Debug.Log("Icone para botão de interação");
    }

    public void mostrarErroAoInteragirComEvento()
    {
        Debug.Log("Erro para interação equivocada");
    }

    public void mostrarEventoBotaoPreso()
    {
        Debug.Log("Botão está preso");
    }
}
