using System;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 1f;
    [SerializeField] float speedOfSpin = 1f;
    [SerializeField] float damage = 50f;

    private void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * projectileSpeed, Space.World);
        transform.Rotate(Vector3.back * 120 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.GetComponent<Attacker>();
        health.DealDamage(damage);
    }
}