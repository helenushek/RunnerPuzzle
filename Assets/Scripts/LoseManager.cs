using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoseManager 
{
    public static void Lose()
    {
        if (Time.time < ImmortalEndTime)
        {
            return;
        }

        if (ShieldYesNo == true)
        {
            ShieldYesNo = false;
            return;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static float ImmortalEndTime;
    public static bool ShieldYesNo;
    
}
