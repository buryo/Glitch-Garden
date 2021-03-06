using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Defender
{
    [SerializeField] GameObject shootPosition = default;
    [SerializeField] GameObject ammo = null;
    // [SerializeField] public bool Shoot { get; private set; } = false;
    [SerializeField] List<Transform> spawners = new List<Transform>();
    Animator animator;

    private void Start()
    {
        SetLaneSpawners();
        animator = GetComponent<Animator>();
    }

    // TODO: Use coroutine to fix this weak ass garbage Update code
    private void Update()
    {
        LaneContainsAttackers();
    }

    /// <summary>
    /// Get all spawners and loop check if it belongs to the same lane as the placed shooter. If so add the spawner to the Spawners list
    /// Extra information: We are checking wether the (rounded) Y positions are the equal of both
    /// </summary>
    private void SetLaneSpawners()
    {
        // Get the reference to Spawner gameObject which contains all spawners
        GameObject SpawnerGameObject = GameObject.Find("Spawners");

        // Check foreach Spawner
        foreach (Transform spawner in SpawnerGameObject.transform)
        {
            // If the Spawner Y pos is approximately the same as the Shooter Y, this means spawner belongs to the shooter's lane
            if (Mathf.Approximately(Mathf.Floor(spawner.position.y), Mathf.Floor(transform.position.y)))
            {
                spawners.Add(spawner);
            }
        }
    }

    /// <summary>
    /// Fires the equiped ammo 
    /// </summary>
    public void Fire()
    {
        GameObject projectile = Instantiate(ammo, shootPosition.transform.position, transform.rotation);
    }

    /// <summary>
    /// Check if the shooter's lane contains any attacker
    /// </summary>
    /// <returns>Boolean</returns>
    private bool LaneContainsAttackers()
    {
        foreach (Transform spawner in spawners)
        {
            if (spawner.childCount > 0)
            {
                animator.SetBool("isAttacking", true);
                return true;
            }
        }
        animator.SetBool("isAttacking", false);
        return false;
    }
}