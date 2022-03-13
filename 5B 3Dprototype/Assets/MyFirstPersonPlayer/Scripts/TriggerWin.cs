/*
 * Josh McGrew
 * Assignment 5B
 * win game when triggered
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UI.won = true;
    }
}
