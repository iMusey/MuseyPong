using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProfileDatabase profileDatabase;
    public prefabData prefabData;


    public UIManager uiManager;
    public UIManager.GameState gamestate;

    public static GameManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        profileDatabase.profiles = ProfileSaveLoad.LoadAllProfiles();
    }

    // Update is called once per frame
    void Update()
    {
        uiManager.SetState(gamestate);
    }
}
