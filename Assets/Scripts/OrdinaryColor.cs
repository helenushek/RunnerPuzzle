using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class OrdinaryColor : MonoBehaviour
{
    [SerializeField] private OrdinaryTsvet ordinaryTsvet;

    private List<OrdinaryTsvet> _spisokTsvetov = new List<OrdinaryTsvet>()
    {
        OrdinaryTsvet.red,
        OrdinaryTsvet.blue,
        OrdinaryTsvet.green,
        OrdinaryTsvet.yellow
    };

    private void OnTriggerEnter(Collider other)
    {
        ColorChanger colorChanger = other.GetComponent<ColorChanger>();
        if (colorChanger == null)
            return;
        
        if (ordinaryTsvet != OrdinaryTsvet.none)
        {
            colorChanger.ChangeColor(ordinaryTsvet);
        }
        else
        {
            OrdinaryTsvet randomTsvet = _spisokTsvetov[Random.Range(0,4)];
            colorChanger.ChangeColor(randomTsvet);
        }

        Destroy(gameObject);
    }
}

public enum OrdinaryTsvet
{
    none,
    red,
    blue,
    green,
    yellow
}