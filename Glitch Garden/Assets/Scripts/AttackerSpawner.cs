using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;

    [SerializeField] Attacker[] attackerPrefab;

    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(3, 3));

            SpawnAttacker();
        }
    }

    void Update()
    {
        
    }

    void SpawnAttacker()
    {
        int range = Random.Range(0, attackerPrefab.Length);

        Attacker newAttacker = Instantiate(attackerPrefab[range], transform.position, transform.rotation) as Attacker;

        newAttacker.transform.parent = transform;
    }
}
