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

    private OrdinaryTsvet _color;

    public static ColorChanger Instance;

    private void Awake()
    {
        Instance ??= this;
        // Instance = Instance ?? this;
        //if (Instance == null) Instance = this;

        // изначальный цвет шарика
        _color = OrdinaryTsvet.red;
    }

    public void ChangeColor(OrdinaryTsvet tsvet)
    {
        _color = tsvet;

        if (tsvet == OrdinaryTsvet.red)
            ball.material.color = red;

        else if (tsvet == OrdinaryTsvet.blue)
            ball.material.color = blue;

        else if (tsvet == OrdinaryTsvet.green)
            ball.material.color = green;

        else if (tsvet == OrdinaryTsvet.yellow)
            ball.material.color = yellow;
    }

    public Color ConvertColor(OrdinaryTsvet tsvet)
    {
        
        if (tsvet == OrdinaryTsvet.red)
        {
            return red;
        }

        else if (tsvet == OrdinaryTsvet.blue)
        {
            return blue;
        }

        else if (tsvet == OrdinaryTsvet.green)
        {
            return green;
        }

        else if (tsvet == OrdinaryTsvet.yellow)
        {
            return yellow;
        }

        throw new Exception("Ошибка");
    }
    
    public OrdinaryTsvet GetColor()
    {
        return _color;
    }
}