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
    [SerializeField] private float immortalTime = 5;
    [SerializeField] private Magnet magnet;

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

    public void AddBonus(OrdinaryTsvet tsvet)
    {
        magnet.MagnetEndTime = 0;
        LoseManager.ShieldYesNo = false;
        LoseManager.ImmortalEndTime = 0;
        
        if (tsvet == OrdinaryTsvet.red)
        {
        }
        else if (tsvet == OrdinaryTsvet.blue)
            LoseManager.ShieldYesNo = true;
        else if (tsvet == OrdinaryTsvet.green)
            magnet.MagnetEndTime = float.PositiveInfinity;
        else if (tsvet == OrdinaryTsvet.yellow)
            LoseManager.ImmortalEndTime = Time.time + immortalTime;
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