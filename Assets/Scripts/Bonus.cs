using System;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    private static OrdinaryTsvet _currentColour;
    [SerializeField] private OrdinaryTsvet bonusColor;

    private void OnTriggerEnter(Collider other)
    {
        if (_currentColour == OrdinaryTsvet.yellow)
        {
            print("+1 очко!");
        }

        other.GetComponent<ColorChanger>().ChangeColor(bonusColor);
        _currentColour = bonusColor;
        
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