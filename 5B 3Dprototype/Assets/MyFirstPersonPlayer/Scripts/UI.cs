/*
 * Josh McGrew
 * Assignment 5B
 * ui manager
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text winText;
    public static bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (won)
        {
            winText.text = "You Win";
        }
    }
}
