using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private Transform obstacle;
    [SerializeField] private float speed;
    [SerializeField] private float leftRight;
    private Vector3 startPosition;

    private void FixedUpdate()
    {
        float offset = (MathF.Sin(Time.time * speed) - 0.5f) * leftRight;
        obstacle.localPosition = startPosition + new Vector3(offset, 0, 0);
    }

    private void Start()
    {
        startPosition = obstacle.position;
    }
}