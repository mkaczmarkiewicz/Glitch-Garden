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

        StopAttacking();      
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void Attack()
    {
        if (!currentTarget)
            return;
        else
        {
            Health targetHealth = currentTarget.GetComponent<Health>();

            if (targetHealth)
            {
                targetHealth.DealDamage();
            }
        }
    }

    public virtual void StopAttacking()
    {
        if (!currentTarget)
        {
            myAnimator.SetBool("isAttacking", false);
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {    
        if (collision.gameObject.tag == "Defender")
        {
            SetTargetToAttack(collision.gameObject);          
        }
    }*/

    public void SetTargetToAttack(GameObject target)
    {
        currentTarget = target;
        myAnimator.SetBool("isAttacking", true);
    }
}
