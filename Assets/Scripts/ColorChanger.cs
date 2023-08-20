using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Slider colorChanger;
    [SerializeField] private Transform ball;
    private string _color;
    private void Update()
    {
        float value = colorChanger.value;
        Color color;
        if (value < 0.25f)
        {
            color = Color.red;
            _color = "Red";
        }
        else if (value < 0.5f)
        {
            color = Color.yellow;
            _color = "Yellow";
        }
        else if (value < 0.75f)
        {
            color = Color.green;
            _color = "Green";
        }
        else
        {
            color = Color.blue;
            _color = "Blue";
        }

        ball.GetComponent<MeshRenderer>().material.color = color;
    }

    public string GetColor()
    {
        return _color;
    }
}