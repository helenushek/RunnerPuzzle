using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private Transform obstacle;
    [SerializeField] private float speed;
    [SerializeField] private float leftRight;
    [SerializeField] private float upDown;
    private Vector3 startPosition;

    private float mixTime;

    private void FixedUpdate()
    {
        float offsetX = (MathF.Sin((Time.time + mixTime) * speed)) * leftRight;
        float offsetY = (MathF.Sin((Time.time + mixTime) * speed)) * upDown;
        obstacle.localPosition = startPosition + new Vector3(offsetX, offsetY, 0);
        
    }

    private void Start()
    {
        startPosition = obstacle.position;
        mixTime = Random.Range(1f, 10f);
    }
}