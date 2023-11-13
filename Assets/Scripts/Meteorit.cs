using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorit : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private float speed;
    [SerializeField] private GameObject meteorit;
    [SerializeField] private GameObject shadow;
    [SerializeField] private Transform player;
    private bool Used;
    private GameObject _newMet;

    private void Update()
    {
        if (_newMet != null)
        {
            _newMet.transform.position = Vector3.MoveTowards(_newMet.transform.position, transform.position, Time.deltaTime * speed);
        }
        
        if (Used == true)
            return;
        if (Math.Abs(transform.position.z - player.position.z) <= distance)
        {
            Used = true;
            Instantiate(shadow, transform.position, Quaternion.identity);
            _newMet = Instantiate(meteorit, transform.position + new Vector3(0,20,0), Quaternion.identity);
        }
    }
}
