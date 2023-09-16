using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private SwipeManager swipeManager;
    [SerializeField] private Transform left;
    [SerializeField] private Transform right;
    [SerializeField] private Transform player;
    [SerializeField] private float speed;

    private void Update()
    {
        float direction = -swipeManager.GetDelta().x;
        float clickPosY = swipeManager.GetPreviousClick().y;

        var multiplier = Screen.height / 1920f;
        if (clickPosY < (400 * multiplier))
            return;

        const int minDelta = 10;
        const int negMinDelta = -10;

        if (direction > minDelta)
        {
            player.position = Vector3.MoveTowards(player.position, right.position, speed);
        }

        if (direction < negMinDelta)
        {
            player.position = Vector3.MoveTowards(player.position, left.position, speed);
        }
    }
}