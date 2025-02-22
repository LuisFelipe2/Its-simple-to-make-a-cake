using UnityEngine;

public class ItemCollector : MonoBehaviour, EventController
{
    public Inventario inventario;
    public UI_ItemCollctor UI;
    public string tagitem;

    void Start()
    {
        UI = FindObjectOfType<UI_ItemCollctor>();
        inventario = FindObjectOfType<Inventario>();
        tagitem = gameObject.tag;
    }

    public void doAction()
    {
        Debug.Log("Chegou aqui");
        string tagitem = this.tagitem;
        UI.mostrarInventario();

        Debug.Log("mostrou a UI");

        if (inventario.possuiItem())
        {
            Debug.Log("tinha item a UI");

            UI.arremessarItem();
            inventario.soltarItem();
            this.tagitem = inventario.getItem();
        }
        else
        {
            Debug.Log("Deixou o this null");
            this.tagitem = null;
        }

        Debug.Log("Salvou-1 " + tagitem);
        inventario.pegarItem(tagitem);
        Debug.Log("Salvou-2 " + tagitem);

        if (tagitem != "Button")
        {
            this.gameObject.SetActive(false);
        }
    }
}
