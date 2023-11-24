using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public static class CoinManager
{
    public static float GetCoin()
    {
        return PlayerPrefs.GetFloat("Coins");
    }

    public static void SetCoin(float Coins)
    {
        Debug.Log(Coins);

        PlayerPrefs.SetFloat("Coins", Coins);
        if (Coins < 0 || Coins > 1000)
        {
            throw new Exception();
        }
    }

    static CoinManager()
    {
        PlayerPrefs.SetFloat("Coins", 0);
    }
}