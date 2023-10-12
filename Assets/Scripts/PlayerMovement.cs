using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    
    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            MovePlayer(ray);
        }
        if (Input.touchCount !=0)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            MovePlayer(ray);
            
        }
    }

    private void MovePlayer(Ray ray)
    {
        RaycastHit[] raycastHits = Physics.RaycastAll(ray);

        for (int i = 0; i < raycastHits.Length; i++)
        {
            if (raycastHits[i].transform.tag == "Road")
            {
                var rayCastHitPosition = raycastHits[i].point;
                rayCastHitPosition.z = player.position.z;
                rayCastHitPosition.y = player.position.y;
                player.position = rayCastHitPosition;
                break;
            }
        }
    }
}