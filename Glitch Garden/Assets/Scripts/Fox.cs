using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Defender")
        {
            GetComponent<Attacker>().SetTargetToAttack(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Gravestone")
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
    }
}
