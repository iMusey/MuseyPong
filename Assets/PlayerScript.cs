using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int color = 0;
    public int paddle = 0;

    public int wins = 0;

    public Image cursor;


    // Start is called before the first frame update
    void Start()
    {
        transform.parent = FindObjectOfType<Canvas>().transform;

        // add player script to list of players
        for (int i = 0; i < GameManager.instance.p.Length; i++)
        {
            if (GameManager.instance.p[i] == null)
            {
                GameManager.instance.p[i] = this;
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        cursor.color = GameManager.instance.prefabData.colors[color];
    }
    public void OnChangeColorR(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            color++;
            if (color >= GameManager.instance.prefabData.colors.Length)
            {
                color = 0;
            }
        }
    }
    public void OnChangeColorL(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            color--;
            if (color < 0)
            {
                color = GameManager.instance.prefabData.colors.Length - 1;
            }
        }
    }
}
