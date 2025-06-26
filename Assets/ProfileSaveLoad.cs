using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ProfileSaveLoad
{
    public static string GetSaveFolder()
    {
        return Application.persistentDataPath + "/Profiles/";
    }

    public static void SaveProfile(PlayerProfile profile)
    {
        Directory.CreateDirectory(GetSaveFolder());
        string path = GetSaveFolder() + profile.name + ".json";

        // write all details of player profile to a json file;
        File.WriteAllText(path, JsonUtility.ToJson(profile, true));
    }

    public static List<PlayerProfile> LoadAllProfiles()
    {
        //create new list to contain output
        List<PlayerProfile> profiles = new List<PlayerProfile>();

        // reference to save directory
        string folder = GetSaveFolder();


        // run for each .json file in the directory
        foreach (string file in Directory.GetFiles(folder, "*.json"))
        {
            // read the text and write the details to a player profile instance
            string json = File.ReadAllText(file);
            PlayerProfile profile = JsonUtility.FromJson<PlayerProfile>(json);
            profiles.Add(profile);
        }

        return profiles;
    }
}
