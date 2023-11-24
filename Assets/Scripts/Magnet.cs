using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    [SerializeField] private Transform sphera;
    [SerializeField] private float speed;
    [SerializeField] private ColorChanger colorChanger;
    public float MagnetEndTime;

    private void Update()
    {
        transform.position = sphera.position;

        if (MagnetEndTime < Time.time)
        {
            return;
        }

        Collider[] hits = Physics.OverlapSphere(transform.position, 10);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i].transform.TryGetComponent<Bonus>(out Bonus bonus))
            {
                if (bonus.BonusColor() == colorChanger.GetColor())
                {
                    Vector3 position = Vector3.MoveTowards(hits[i].transform.position, transform.position, speed);
                    hits[i].transform.position = position;
                }
            }
        }
    }
}