using System;
using System.Collections;
using UnityEngine;

public class SpawnAttacker : MonoBehaviour
{
    [SerializeField] Attacker lizard = default;
    [SerializeField] bool spawnerActive = default;

    IEnumerator Start()
    {
        while (spawnerActive)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(6, 10));
            Spawn();
        }
    }

    private void Spawn()
    {
        Attacker lizard = Instantiate(this.lizard, transform.position, Quaternion.identity);
    }
}