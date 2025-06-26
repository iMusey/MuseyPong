using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public enum GameState
    {
        MainMenu,
        CharSelect,
        Gameplay
    }

    // current state
    public GameState gamestate;

    // diff screens
    public GameObject mainMenu;
    public GameObject charSelect;
    public GameObject gameplay;

    public void SetState(GameState state)
    {
        gamestate = state;

        mainMenu.SetActive(gamestate == GameState.MainMenu);
        charSelect.SetActive(gamestate == GameState.CharSelect);
        gameplay.SetActive(gamestate == GameState.Gameplay);
    }

}
