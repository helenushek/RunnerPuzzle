using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private SwipeManager swipeManager;
   [SerializeField] private Vector3 left;
   [SerializeField] private Vector3 middle;
   [SerializeField] private Vector3 right;
   [SerializeField] private Transform player;
   private RoadPosition _roadPosition;
   private void Update()
   {
       float direction = swipeManager.GetDelta().x;
       if (_roadPosition == RoadPosition.left)
       {
           if (direction > 10)
           {
               _roadPosition = RoadPosition.middle;
               player.localPosition = middle;
           }
       }
       else if (_roadPosition == RoadPosition.middle)
       {
           if (direction > 10)
           {
               _roadPosition = RoadPosition.right;
               player.localPosition = right;
           }
           else if (direction < 10)
           {
               _roadPosition = RoadPosition.left;
               player.localPosition = left;
           }
       }
       else if (_roadPosition == RoadPosition.right)
       {
           if (direction < 10)
           {
               _roadPosition = RoadPosition.middle;
               player.localPosition = middle;
           }
       }

   }
}

enum RoadPosition
{
    left,
    middle,
    right
}
