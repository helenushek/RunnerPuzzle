using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        player.position = player.position + new Vector3(0, 0, speed);

    }
}
