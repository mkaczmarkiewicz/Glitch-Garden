using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
   // [SerializeField] GameObject deathVFX;

    int health = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //for attackers
        if (this.tag == "Attacker")
        {
            if (collision.gameObject.tag == "Projectile")
                DealDamage();           
        }
    }

    public void DealDamage()
    {
        health--;

        if (health <= 0)
            Die();
    }

    private void Die()
    {
       // Destroy(Instantiate(deathVFX, transform.position, transform.rotation), 2f);

        Destroy(this.gameObject);
    }
}
