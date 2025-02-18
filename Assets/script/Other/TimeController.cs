using UnityEngine;

public class TimeController : MonoBehaviour
{
    private UI_TimeController UI;
    public int maximunTimeInSeconds = 180;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        UI.MostarTempo(maximunTimeInSeconds);
        time = maximunTimeInSeconds;
        InvokeRepeating("SubtraiTempo", 1000, maximunTimeInSeconds);
    }

    // Update is called once per frame
    public void SubtraiTempo()
    {
        UI.MostarTempo(--time);
    }
}
