using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private Vector3 offset;

    private void Update()
    {
        var playerPos = playerPosition.position + offset;
        // позиция.x = позицияКамеры.x
        playerPos.x = transform.position.x;
        transform.position = playerPos;
    }
}
