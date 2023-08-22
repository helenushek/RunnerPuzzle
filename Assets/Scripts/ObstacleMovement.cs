using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private Transform obstacle;
    [SerializeField] private float speed;
    [SerializeField] private float leftRight;
    [SerializeField] private float upDown;
    private Vector3 startPosition;

    private void FixedUpdate()
    {
        float offsetX = (MathF.Sin(Time.time * speed)) * leftRight;
        float offsetY = (MathF.Sin(Time.time * speed)) * upDown;
        obstacle.localPosition = startPosition + new Vector3(offsetX, offsetY, 0);
        
    }

    private void Start()
    {
        startPosition = obstacle.position;
    }
}