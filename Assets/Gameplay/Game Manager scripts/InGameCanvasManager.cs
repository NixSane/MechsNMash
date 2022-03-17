using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCanvasManager : MonoBehaviour
{
    [Header("UI Canvas objects")]
    [Tooltip("The canvas for gameplay UI (reticle, health, boost gauge")]
    public GameObject gamePlayUI;
    [Tooltip("Pause UI")]
    public GameObject pauseUI;


    // Start is called before the first frame update
    void Start()
    {
        // If you forget to manually set the canvases, no worries
        if (gamePlayUI == null) { gamePlayUI = GameObject.Find("Gameplay UI"); }
        if (pauseUI == null) { pauseUI = GameObject.Find("Pause UI"); }
    }

    public void SetGameplay()
    {
        gamePlayUI.SetActive(true);
        pauseUI.SetActive(false);
    }

    public void SetPauseMenu()
    {
        pauseUI.SetActive(true);
        gamePlayUI.SetActive(false);
    }
}
