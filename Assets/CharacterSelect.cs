using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public prefabData prefabData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TwoPlayerClick()
    {
        GameManager.instance.gamestate = UIManager.GameState.Gameplay;
    }
}
