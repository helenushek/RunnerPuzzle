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
        
        if (bonusColor != colorChanger.GetColor())
        {
            return;
        }
        
        
        if (bonusColor == OrdinaryTsvet.red)
        {
            CoinManager.SetCoin(CoinManager.GetCoin()+5);
        }
        else
        {
            CoinManager.SetCoin(CoinManager.GetCoin()+1);
        }
        
        colorChanger.AddBonus(bonusColor);

        Destroy(gameObject);
    }

    private void Start()
    {
        if (bonusColor == OrdinaryTsvet.none)
        {
            throw new Exception("Цвет не назначен");
        }
        
        Color color = ColorChanger.Instance.ConvertColor(bonusColor);
        transform.GetComponent<MeshRenderer>().material.color=color;
    }

    public OrdinaryTsvet BonusColor()
    {
        return bonusColor;
    }
}