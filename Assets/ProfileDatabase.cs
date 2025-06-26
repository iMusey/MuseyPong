using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ProfileDatabase", menuName = "Game/ProfileDatabase")]
public class ProfileDatabase : ScriptableObject
{
    public List<PlayerProfile> profiles;
}
