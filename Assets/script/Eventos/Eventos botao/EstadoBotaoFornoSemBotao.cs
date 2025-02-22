using UnityEngine;

public class EstadoBotaoFornoSemBotao : MonoBehaviour, EstadoEventoBot�o
{
    public int tempoDeAnimacaoEmMs = 3000;
    public Inventario inventario;
    private Animator animator;

    void Start()
    {
        animator = GameObject.FindWithTag("Button").GetComponent<Animator>();
        inventario = FindFirstObjectByType<Inventario>();
    }

    public EstadoEventoBot�o mudarDeEstado()
    {
        Debug.Log("EstadoBotaoFornoSemBotao");
        Debug.Log("iventario: " + inventario.getItem());
        if (inventario.getItem() == "Button")
        {
            animator.SetTrigger("put_button");
            gameObject.SetActive(true);
            return new EstadoBotaoFornoBotaoSolto();
        }
        else if (inventario.getItem() == "Cola")
        {
            return new EstadoBotaoFornoComCola();
        }

        return this;
    }
}
