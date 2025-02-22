using UnityEngine;

public class EventoMovel : MonoBehaviour, EventController
{
    private UI_ItemCollctor UI;
    private Inventario inventario;
    private string item;

    void Start()
    {
        UI = FindObjectOfType<UI_ItemCollctor>();
        inventario = FindObjectOfType<Inventario>();
        item = gameObject.tag;
    }

    public void doAction()
    {
        UI.mostrarInventario();
        inventario.pegarItem(item);
    }
}
