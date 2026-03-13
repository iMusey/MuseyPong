using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ProfileDatabase profileDatabase;
    public prefabData prefabData;


    public UIManager uiManager;
    public UIManager.GameState gamestate;

    public PlayerScript[] p;

    public static GameManager instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        p = new PlayerScript[10];

        Directory.CreateDirectory(ProfileSaveLoad.GetSaveFolder());
        profileDatabase.profiles = ProfileSaveLoad.LoadAllProfiles();
    }

    // Update is called once per frame
    void Update()
    {
        uiManager.SetState(gamestate);
    }
}
