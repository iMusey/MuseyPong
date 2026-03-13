using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharSelector : MonoBehaviour
{
    public prefabData prefabData;

    public int index = 0;
    public int playerNum;
    public PlayerScript pScript;

    public Image img;
    public TextMeshProUGUI pName;
    public TextMeshProUGUI pDesc;
    public TextMeshProUGUI pStats;

    // Start is called before the first frame update
    public void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (pScript == null)
        {
            pScript = GameManager.instance.p[playerNum];
        }


        img.sprite = prefabData.paddleSprites[index];
        img.color = prefabData.colors[pScript.color];
        pName.text = prefabData.paddleNames[index];
        pDesc.text = prefabData.paddleDescriptions[index];
        string[] statsTxt = prefabData.paddleStats[index].Split(".");
        pStats.text = "Speed: " + statsTxt[0] + "\nStrength: " + statsTxt[1] + "\nStamina: " + statsTxt[2];
    }

    public void CycleLeft()
    {
        index--;
        if (index < 0)
        {
            index = prefabData.paddles.Length - 1;
        }
    }
    public void CycleRight()
    {
        index++;
        if (index >= prefabData.paddles.Length)
        {
            index = 0;
        }
    }
}
