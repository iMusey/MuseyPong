using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/PrefabData")]
public class prefabData : ScriptableObject
{
    public GameObject[] paddles;
    public Sprite[] paddleSprites;
}
