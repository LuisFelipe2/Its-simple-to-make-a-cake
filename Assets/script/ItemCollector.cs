using UnityEngine;

public class ItemCollector : MonoBehaviour, EventController
{
    public Inventario inventario;
    public UI_ItemCollctor UI;
    public Item item;

    public void doAction()
    {
        Item item = this.item;
        UI.mostrarInventario(gameObject);

        if (inventario.possuiItem())
        {
            UI.arremessarItem(inventario.getItem());
            inventario.soltarItem();
            this.item = inventario.getItem();
        }
        else
        {
            this.item = null;
        }

        inventario.pegarItem(item);
    }
}
