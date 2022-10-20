using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject resourceHolder;
    public GameObject player;

    public float moveSpeed = 5f;
    public float health = 5;
    public float gold = 1;
    public float enemyDamage = 1;

    public float attackCooldown = 3;
    public float attackTimer = 3;


    private Rigidbody2D rb;
    private Vector2 movement;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        resourceHolder = GameObject.FindWithTag("Resource Holder");

        resourceHolder.GetComponent<EnemySpawner>().enemyAmount += 1;

        rb = this.GetComponent<Rigidbody2D>();

        health = health + resourceHolder.GetComponent<GameResources>().enemyExtraHealth;
        gold = gold + resourceHolder.GetComponent<GameResources>().enemyExtraGold;
    }
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;

        if (attackCooldown > 0)
        {
            attackCooldown -= Time.deltaTime;
        }

        if (health <= 0)
        {
            player.GetComponent<Player>().gold += gold;
            player.GetComponent<Player>().updateVariables = true;

            Destroy(gameObject);
            resourceHolder.GetComponent<EnemySpawner>().enemyAmount -= 1;
        }
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && attackCooldown <= 0)
        {
            player.GetComponent<Player>().health -= enemyDamage;
            player.GetComponent<Player>().updateVariables = true;
            attackCooldown = attackTimer;
        }
    }






    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

}
