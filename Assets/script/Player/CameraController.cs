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
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(yRotation, xRotation, 0f);
        playerBody.Rotate(new Vector3(mouseX, mouseY, 0));


        /// Verificar Hover
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.GetComponent<EventController>() == null)
            {
                UI.mostrarEvento();
            }
        }
    }

    public void interagir()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.GetComponent<EventController>() == null)
            {
                Debug.Log("Colocar Som de erro");
                return;
            }

            EventController interactable = hit.collider.GetComponent<EventController>();
            Debug.Log("Colocar Som de erro");
            interactable.doAction();
        }
    }

    public void FixCamera()
    {
        Debug.Log("Fixar a Camera");
    }

}