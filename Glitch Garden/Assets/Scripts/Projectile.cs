using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    int speed = 3;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
