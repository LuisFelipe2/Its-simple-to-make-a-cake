using UnityEngine;

public class EstadoBotaoFornoBotaoSolto : MonoBehaviour, EstadoEventoBot�o
{
    public int tempoDeAnimacaoEmMs = 3000;
    private GameObject button;
    private Animator animator;

    void Start()
    {
        button = GameObject.FindWithTag("Button");
        animator = button.GetComponent<Animator>();
    }

    public EstadoEventoBot�o mudarDeEstado()
    {
        animator.SetTrigger("button_down");
        button.GetComponent<CapsuleCollider>().enabled = true;
        return GetComponent<EstadoBotaoFornoSemBotao>();
    }
}
