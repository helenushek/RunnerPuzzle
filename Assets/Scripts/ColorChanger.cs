using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Slider colorChanger;
    [SerializeField] private Transform ball;

    private void Update()
    {
        float value = colorChanger.value;
        Color color;
        if (value < 0.25f)
        {
            color = Color.red;
        }
        else if (value < 0.5f)
        {
            color = Color.yellow;
        }
        else if (value < 0.75f)
        {
            color = Color.green;
        }
        else
        {
            color = Color.blue;
        }

        ball.GetComponent<MeshRenderer>().material.color = color;
    }
}