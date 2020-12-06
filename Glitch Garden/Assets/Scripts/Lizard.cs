using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Defender" || collision.gameObject.tag == "Gravestone")
        {
            GetComponent<Attacker>().SetTargetToAttack(collision.gameObject);
        }
    }
}
