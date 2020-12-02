using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float speed = 0f;

    GameObject currentTarget;

    Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);

        if (myAnimator.GetBool("isAttacking"))
        {
            Attack();
        }
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void Attack()
    {
        //atakuj currentTarget;
    }

    public void StopAttacking()
    {
        myAnimator.SetBool("isAttacking", false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {    
        if (collision.gameObject.tag == "Defender")
        {
            currentTarget = collision.gameObject;
            myAnimator.SetBool("isAttacking", true);
        }
    }
}
