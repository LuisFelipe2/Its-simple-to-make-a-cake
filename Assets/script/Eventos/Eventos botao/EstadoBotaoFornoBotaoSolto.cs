using UnityEngine;

public class EstadoBotaoFornoBotaoSolto : MonoBehaviour, EstadoEventoBotão
{
    public int tempoDeAnimacaoEmMs = 3000;
    private GameObject button;
    private Animator animator;

    void Start()
    {
        button = GameObject.FindWithTag("Button");
        animator = button.GetComponent<Animator>();
    }

    public EstadoEventoBotão mudarDeEstado()
    {
        animator.SetTrigger("button_down");
        button.GetComponent<CapsuleCollider>().enabled = true;
        return GetComponent<EstadoBotaoFornoSemBotao>();
    }
}
