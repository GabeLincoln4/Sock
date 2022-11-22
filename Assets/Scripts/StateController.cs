using UnityEngine;

public class StateController : MonoBehaviour
{
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
}