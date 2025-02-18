using UnityEngine;

public class EventoMovel : MonoBehaviour, EventController
{
    private CameraController controller;

    public void doAction()
    {
        controller.FixCamera();
    }
}
