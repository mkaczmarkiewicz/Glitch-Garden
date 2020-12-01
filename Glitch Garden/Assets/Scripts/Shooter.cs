using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject zuchciniGun;

    AttackerSpawner myLaneSpawner;
    Animator animator;

    private void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else 
        {
            animator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool isInTheSameLane = Mathf.Abs( (spawner.transform.position.y) - transform.position.y) < 0.100001f;
            //to 0.1 jest takim rozwiązaniem na trytytkę, bo ten skrypt znajduje się na dziecku "Body" które jest przesunięte względem rodzica o 0.1
            if (isInTheSameLane)
            {
                myLaneSpawner = spawner;
                break;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        return myLaneSpawner.transform.childCount > 0;
    }

    public void Fire()
    {
        Instantiate(projectile, zuchciniGun.transform.position, zuchciniGun.transform.rotation);
    }
}
