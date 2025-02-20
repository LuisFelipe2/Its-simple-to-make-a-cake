using UnityEngine;

public class CameraController : MonoBehaviour
{
    private UI_ItemCollctor UI;
    public float sensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        UI = FindObjectOfType<UI_ItemCollctor>();
    }

    void Update()
    {
        /// Movimento
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation += mouseX;
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(yRotation, xRotation, 0f);
    }

    private void FixedUpdate()
    {
        // Lan�a o Raycast a partir do centro da tela
        Ray ray = new Ray(this.GetComponent<Camera>().transform.position, GetComponent<Camera>().transform.forward);
        RaycastHit hit;

        Debug.Log("Lan�ando Raycast...");
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 2f);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, ~0)) // Detecta todas as Layers
        {
            Debug.Log("Objeto atingido: " + hit.collider.name);
            Debug.Log("Tag do objeto: " + hit.collider.tag);

            ItemCollector item = hit.collider.GetComponent<ItemCollector>();
            if (item != null)
            {
                Debug.Log("ItemCollector encontrado!");
                UI.mostrarEvento();
            }
            else
            {
                Debug.Log("ItemCollector N�O encontrado.");
                UI.desligarEventos();
            }
        }
        else
        {
            Debug.Log("Nenhum objeto atingido.");
            UI.desligarEventos();
        }
    }

    public void interagir()
    {
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            EventController interactable = hit.collider.GetComponent<EventController>();

            if (interactable == null)
            {
                Debug.Log("Colocar Som de erro");
                return;
            }

            Debug.Log("Interagindo com: " + hit.collider.name);
            interactable.doAction();
        }
    }

    public void FixCamera()
    {
        Debug.Log("Fixar a Camera");
    }
}
