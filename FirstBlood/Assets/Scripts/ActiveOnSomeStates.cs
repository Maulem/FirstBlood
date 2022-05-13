using System.Linq;
using UnityEngine;

public class ActiveOnSomeStates : MonoBehaviour {
    public GameManager.GameState[] activeStates;
    GameManager gm;

    void Start() {
        GameManager.changeStateDelegate += UpdateVisibility;
        gm = GameManager.GetInstance();

        UpdateVisibility();
    }

    void UpdateVisibility() {
        if (activeStates.Contains(gm.gameState)) {
            gameObject.SetActive(true);
        }
        else {
            gameObject.SetActive(false);
        }
    }

    public void Iniciar() {
        gm.ChangeState(GameManager.GameState.HISTORY);
    }

    public void Tutorial() {
        gm.ChangeState(GameManager.GameState.TUTORIAL);
    }

    public void Play() {
        gm.ChangeState(GameManager.GameState.GAME);
    }

    public void Configs() {
        gm.ChangeState(GameManager.GameState.CONFIG);
    }

    public void Menu() {
        gm.ChangeState(GameManager.GameState.MENU);
        gm.reset = true;
    }

    public void Unpause() {
        gm.ChangeState(GameManager.GameState.GAME);
    }

}
