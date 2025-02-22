using UnityEngine;

public class Inventario : MonoBehaviour
{
    public string item;

    public bool possuiItem()
    {
        return item != null;
    }

    public void pegarItem(string item)
    {
        Debug.Log("Chegou aqui o item; " + item);
        this.item = item;
    }

    public void soltarItem()
    {
        item = null;
    }

    public string getItem()
    {
        return item;
    }
}
