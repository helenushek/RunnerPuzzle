using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    [SerializeField] private Transform roadMovement;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        roadMovement.position = roadMovement.position + new Vector3(0, 0, -speed);
        
    }
}
