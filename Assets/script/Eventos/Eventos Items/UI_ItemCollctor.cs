using UnityEngine;

public class UI_ItemCollctor : MonoBehaviour
{
    public Canvas UI_iconeBtnInteracao;
    public Canvas UI_erroEvento;
    public Canvas UI_botaoTravado;
    public Canvas UI_mostrarInventario;
    public Canvas UI_arremecarItem;

    public void desligarEventos()
    {
        selectUI(UI_Enum.NOTHING);
    }

    public void mostrarInventario()
    {
        selectUI(UI_Enum.INVENTARIO);
    }

    public void arremessarItem()
    {
        selectUI(UI_Enum.DROP_ITEM);
    }

    public void mostrarEvento()
    {
        selectUI(UI_Enum.BTN_INTERACAO);
    }

    public void mostrarErroAoInteragirComEvento()
    {
        selectUI(UI_Enum.ERRO_EVENTO);
    }

    public void mostrarEventoBotaoPreso()
    {
        selectUI(UI_Enum.BTN_TRAVADO);
    }

    private void selectUI(UI_Enum ui_enum)
    {
        UI_botaoTravado.gameObject.SetActive(UI_Enum.BTN_TRAVADO == ui_enum);
        UI_iconeBtnInteracao.gameObject.SetActive(UI_Enum.BTN_INTERACAO == ui_enum);
        UI_erroEvento.gameObject.SetActive(UI_Enum.ERRO_EVENTO == ui_enum);
        UI_mostrarInventario.gameObject.SetActive(UI_Enum.INVENTARIO == ui_enum);
        UI_arremecarItem.gameObject.SetActive(UI_Enum.DROP_ITEM == ui_enum);
    }
}
