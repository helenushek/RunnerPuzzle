using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryOrFail : MonoBehaviour
{
    [SerializeField] private ColorChanger colorChanger;
    public bool IsWhite;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Magnet")
            return;
        
        if (other.tag == "endOfLevel" || other.tag == "Meteorit")
            LoseManager.Lose();

        NaznachenieTsveta naznachenieTsveta = other.GetComponentInChildren<NaznachenieTsveta>();
        if (naznachenieTsveta == null)
            return;

        if (IsWhite)
        {
            colorChanger.ChangeColor(naznachenieTsveta.tsvet);
        }

        else if (naznachenieTsveta.tsvet == colorChanger.GetColor())
        {
            if (other.tag != "bullet")
                print("препятствие пройдено!");
        }
        else
        {
            LoseManager.Lose();
        }
    }
}