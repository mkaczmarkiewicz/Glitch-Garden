using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    int speed = 3;
    
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Attacker")
            Destroy(this.gameObject);
    }
}
