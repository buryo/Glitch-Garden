using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    // [SerializeField] float speedOfSpin = 1f;
    [SerializeField] float damage = 50f;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if Collider has the Attacker script.
        if (other.GetComponent<Attacker>())
        {
            var attacker = other.GetComponent<Attacker>();
            attacker.DealDamage(damage);

            // Destroy projectile after hitting an enemy.
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Collider has no Attacker component (script)");
        }
    }
}