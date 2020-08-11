using System;
using System.Collections;
using UnityEngine;

public class SpawnAttacker : MonoBehaviour
{
    [SerializeField] Attacker lizard = default;
    [SerializeField] bool spawnerActive = default;
    [SerializeField] private int spawnTimer = 3;
    public event Action OnSpawn;

    IEnumerator Start()
    {
        while (spawnerActive)
        {
            yield return new WaitForSeconds(spawnTimer);
            Spawn();
        }
    }

    private void Spawn()
    {
        Attacker lizard = Instantiate(this.lizard, transform.position, Quaternion.identity) as Attacker;
        lizard.transform.parent = transform;

        if (OnSpawn != null)
            OnSpawn.Invoke();
    }
}