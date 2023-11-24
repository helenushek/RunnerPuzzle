using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorit2 : MonoBehaviour
{
    [SerializeField] private float distance;
    [SerializeField] private float speed;
    [SerializeField] private GameObject meteorit;
    [SerializeField] private Transform player;
   
    private bool Used;
    private Transform _newMet2;

    private void Update()
    {
        if (_newMet2 != null)
        {
            _newMet2.Translate(new Vector3(0,0,speed*Time.deltaTime));
        }
        
        if (Used == true)
            return;
        if (Math.Abs(transform.position.z - player.position.z) <= distance)
        {
            Used = true;
            _newMet2 = Instantiate(meteorit.transform, transform.position, Quaternion.identity);
        }
    }
}
