using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaznachenieTsveta : MonoBehaviour
{
    [SerializeField] public OrdinaryTsvet tsvet;

    private void Start()
    {
        Color color = ColorChanger.Instance.ConvertColor(tsvet);
        transform.GetComponent<MeshRenderer>().material.color=color;
    }
}

