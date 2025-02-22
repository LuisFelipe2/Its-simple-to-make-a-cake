using UnityEngine;

public class EstadoBotaoFornoSemBotao : MonoBehaviour, EstadoEventoBotão
{
    public int tempoDeAnimacaoEmMs = 3000;
    public Inventario inventario;
    private Animator animator;

    void Start()
    {
        animator = GameObject.FindWithTag("Button").GetComponent<Animator>();
        inventario = FindFirstObjectByType<Inventario>();
    }

    public EstadoEventoBotão mudarDeEstado()
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
