using System;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private OrdinaryTsvet bonusColor;

    private void OnTriggerEnter(Collider other)
    {
        var colorChanger = other.GetComponent<ColorChanger>();
        if(colorChanger == null)
            return;
        
        if (bonusColor.ToString() != colorChanger.GetColor())
        {
            return;
        }
        
        print("+1 очко!");

        
        colorChanger.ChangeColor(bonusColor);

        Destroy(gameObject);
    }

    private void Start()
    {
        if (bonusColor == OrdinaryTsvet.none)
        {
            throw new Exception("Цвет не назначен");
        }
    }
}