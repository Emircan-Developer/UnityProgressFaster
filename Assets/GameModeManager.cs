using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager
{
    GameMode gameMode;
    void Start()
    {
         gameMode = GameMode.Normal;
    }

    void Update()
    {
        
    }
    public GameMode GetGameMode()
    {
        return gameMode;
    }
    public void SetGameMode(GameMode gameMode)
    {
        this.gameMode = gameMode;
    } 
}
