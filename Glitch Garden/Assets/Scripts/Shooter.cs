using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject zuchciniGun;

    public void Fire()
    {
        Instantiate(projectile, zuchciniGun.transform.position, zuchciniGun.transform.rotation);
    }
}
