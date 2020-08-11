using System;
using UnityEngine;

/// <summary>
/// This is abstract because all defenders have similiar logic
/// </summary>
public abstract class Defender : MonoBehaviour
{
    [SerializeField] public int Health { get; protected set; } = 100;

    public event Action OnDefenderGotHit;

    /// <summary>
    /// The price of the defender in Stars
    /// </summary>
    /// <value>100</value>
    public int StarCost { get; } = 100;

    /// <summary>
    /// Defender taking damage
    /// </summary>
    /// <param name="damage">Damage value</param>
    protected void TakeDamage(int damage)
    {
        Health -= damage;
        OnDefenderGotHit(); // TODO: For later

        if (Health >= 0)
        {
            Die();
        }
    }

    /// <summary>
    /// Call when defender dies
    /// </summary>
    protected void Die()
    {
        Destroy(gameObject);
    }
}
