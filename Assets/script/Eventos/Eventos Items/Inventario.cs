using UnityEngine;

public class Inventario : MonoBehaviour
{
    public Item item;

    public bool possuiItem()
    {
        return item != null;
    }

    public void pegarItem(Item item)
    {
        this.item = item;
    }

    public void soltarItem()
    {
        item = null;
    }

    public Item getItem()
    {
        return item;
    }
}
