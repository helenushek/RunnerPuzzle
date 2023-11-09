using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private OrdinaryTsvet _tsvet;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            ColorChanger colorChanger = other.GetComponent<ColorChanger>();
            if (colorChanger == null)
                return;
            
            if (colorChanger.GetColor() !=_tsvet.ToString())
                LoseManager.Lose();
        }
    }

    public void Init(OrdinaryTsvet tsvet)
    {
        _tsvet = tsvet;
    }
}
