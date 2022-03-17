using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GAMESTATE
{
    PLAY,
    PAUSE
}


public class GameWorldManagerScript : MonoBehaviour
{
    public GAMESTATE gameState;

    [Header("Sub Managers")]
    [Tooltip("UI manager")]
    [SerializeField] InGameCanvasManager canvasManager;

    private void Awake()
    {
        // If you forget to manually set the sub-managers
        canvasManager = GameObject.Find("Game UI Manager").GetComponent<InGameCanvasManager>();

        // Set world state
        gameState = GAMESTATE.PLAY;
    }

    // Control other managers via this script

    // Update is called once per frame
    void Update()
    {
        // Simple state controller
        switch (gameState)
        {
            case GAMESTATE.PLAY:
                canvasManager.SetGameplay();
                Time.timeScale = 1.0f;
                break;
            case GAMESTATE.PAUSE:
                canvasManager.SetPauseMenu();
                Time.timeScale = 0.0f;
                break;
            default:
                break;
        }
    }
}
