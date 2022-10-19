using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject resourceHolder;
    public GameObject player;

    public float moveSpeed = 5f;
    public float health = 5;
    public float enemyDamage = 1;

    public float attackCooldown = 3;
    public float attackTimer = 3;


    private Rigidbody2D rb;
    private Vector2 movement;
    
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        resourceHolder = GameObject.FindWithTag("Resource Holder");

        rb = this.GetComponent<Rigidbody2D>();

        health = health + resourceHolder.GetComponent<GameResources>().enemyExtraHealth;
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
            attackCooldown = attackTimer;
        }


    }






    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

}
