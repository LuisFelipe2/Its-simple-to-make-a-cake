using UnityEngine;

public class ItemCollector : MonoBehaviour, EventController
{
    public Inventario inventario;
    public UI_ItemCollctor UI;
    public Item item;

    void Start()
    {
        UI = FindObjectOfType<UI_ItemCollctor>();
        inventario = FindObjectOfType<Inventario>();
    }

    public void doAction()
    {
        Item item = this.item;
        UI.mostrarInventario();

        if (inventario.possuiItem())
        {
            UI.arremessarItem();
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
