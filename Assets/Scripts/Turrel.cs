using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Turrel : MonoBehaviour
{
    // time - время, через которое будет лететь следуюящая поля
    [SerializeField] private float time;
    [SerializeField]private GameObject bullet;

    [SerializeField] private Vector3 direction;
    // timer - время, которое прошло с последнего выпуска пули
    private float timer;
    
    
    private void Update()
    {
        // увеличиваем время, с выпуска пули на deltatime
        timer += Time.deltaTime;
        
        // если прошло мало времени, то выходим
        if (timer < time)
        {
            return;
        }
        
        // основной код (кидание пули)
        timer = 0;
        GameObject BulletClone = Instantiate(bullet);
        BulletClone.transform.position = transform.position;
        BulletClone.GetComponent<Rigidbody>().AddForce(direction);
        BulletClone.GetComponent<NaznachenieTsveta>().tsvet = GetComponent<NaznachenieTsveta>().tsvet;
    }
}
