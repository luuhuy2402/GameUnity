using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesColider : MonoBehaviour
{
    [SerializeField] float health, maxHealth = 4;
    [SerializeField] FloatingHealthBar healthBar;
    Rigidbody2D rb;



    void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        healthBar = GetComponentInChildren<FloatingHealthBar>();

    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        healthBar.UpdateHealthBar(health, maxHealth);
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // if (other.gameObject.CompareTag("IsDestroy"))
        // {
        //     Destroy(gameObject);
        // }
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(2f);
            Destroy(other.gameObject);
        }
    }
}
