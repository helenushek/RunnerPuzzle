using System;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private MeshRenderer ball;

    [SerializeField] private Color red;
    [SerializeField] private Color blue;
    [SerializeField] private Color green;
    [SerializeField] private Color yellow;

    private string _color;

    private void Start()
    {
        _color = "red";
    }

    public void ChangeColor(OrdinaryTsvet tsvet)
    {
        if (tsvet == OrdinaryTsvet.red)
        {
            _color = "red";
            ball.material.color = red;
        }

        else if (tsvet == OrdinaryTsvet.blue)
        {
            _color = "blue";
            ball.material.color = blue;
        }

        else if (tsvet == OrdinaryTsvet.green)
        {
            _color = "green";
            ball.material.color = green;
        }

        else if (tsvet == OrdinaryTsvet.yellow)
        {
            _color = "yellow";
            ball.material.color = yellow;
        }

        else
        {
            _color = "none";
        }
        
        print(_color);
    }
    
    public string GetColor()
    {
        return _color;
    }
}