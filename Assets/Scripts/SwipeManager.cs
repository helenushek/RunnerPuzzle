using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeManager : MonoBehaviour
{
    private bool _tapScreen;
    private bool _touchSupported;
    private Vector2 _delta;
    private Vector2 _previousClickPosition;

    private void Start()
    {
        _tapScreen = Input.touchSupported;
        StartCoroutine(TouchDirection());
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.touchCount != 0)
        {
            _tapScreen = true;
        }
        else
        {
            _tapScreen = false;
        }
    }

    private IEnumerator TouchDirection()
    {
        while (true)
        {
            Vector2 firstTouchPosition = new Vector2(0, 0);
            if (_tapScreen)
            {
                if (_touchSupported)
                {
                    firstTouchPosition = Input.touches[0].position;
                }
                else
                {
                    firstTouchPosition = Input.mousePosition;
                }
            }

            yield return new WaitForSeconds(0.1f);

            if (firstTouchPosition == new Vector2(0, 0) || !_tapScreen)
            {
                _delta = new Vector2(0, 0);
                continue;
            }

            Vector2 secondTouchPosition = new Vector2(0, 0);

            if (_tapScreen)
            {
                if (_touchSupported)
                {
                    secondTouchPosition = Input.touches[0].position;
                }
                else
                {
                    secondTouchPosition = Input.mousePosition;
                }
            }
            
            if (secondTouchPosition == new Vector2(0, 0))
            {
                _delta = new Vector2(0, 0);
                continue;
            }

            _previousClickPosition = secondTouchPosition;
            _delta = firstTouchPosition - secondTouchPosition;
        }
    }

    public Vector2 GetDelta()
    {
        return _delta;
    }

    public Vector2 GetPreviousClick()
    {
        return _previousClickPosition;
    }
}