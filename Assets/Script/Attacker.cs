using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] [Range(0f, 5f)] float attackerSpeed = 0f;
    [SerializeField] [Range(1f, 300f)] float health = 100f;
    [SerializeField] GameObject explosion = default;
    int starPoints = 25;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * attackerSpeed);
    }


    public void SetMovementSpeed(float speed)
    {
        attackerSpeed = speed;
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            StarController.AddStar(starPoints);
            TriggerDeathVFX();
        }
    }

    private void TriggerDeathVFX()
    {
        Destroy(gameObject);
        var particles = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(particles, 1f);
    }
}
