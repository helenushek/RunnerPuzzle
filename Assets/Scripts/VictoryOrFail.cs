using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryOrFail : MonoBehaviour
{
    [SerializeField] private ColorChanger colorChanger;
    private List<string> _allowedLayers = new List<string>();
    private void OnTriggerEnter(Collider other)
    {
        string layerName = (LayerMask.LayerToName(other.gameObject.layer));
        if (_allowedLayers.Contains(layerName))
        {
            if (string.Equals(colorChanger.GetColor(), layerName, StringComparison.CurrentCultureIgnoreCase))
            {
                print("+1 очко!");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
        else
        {
            if (layerName == "endOfLevel")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        
    }

    private void Start()
    {
        _allowedLayers.Add("Green");
        _allowedLayers.Add("Red");
        _allowedLayers.Add("Blue");
        _allowedLayers.Add("Yellow");
        
    }
}
