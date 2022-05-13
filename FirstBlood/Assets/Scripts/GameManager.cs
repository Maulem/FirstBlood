using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {
    private static GameManager _instance;
    public enum GameState { MENU, GAME, PAUSE, ENDGAME, CONFIG, TUTORIAL, HISTORY };
    public GameState gameState { get; private set; }
    public bool reset = false;

    
    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    public void ChangeState(GameState nextState) {
        if (gameState == GameState.ENDGAME && nextState == GameState.MENU) reset = true;
        gameState = nextState;
        changeStateDelegate();
    }

    private GameManager() {
        gameState = GameState.MENU;
    }

    public static GameManager GetInstance() {
        if(_instance == null) {
            _instance = new GameManager();
        }

        return _instance;
    }
}
