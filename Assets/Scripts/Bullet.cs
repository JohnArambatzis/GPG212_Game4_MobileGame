using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject resourceHolder;
    public GameObject enemy;

    public int bullet = 1;

    public float moveSpeed = 5f;
    public float bulletDamage = 2;
    public float timer = 5f;


    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        timer = 5f;
        enemy = GameObject.FindWithTag("Enemy");
        resourceHolder = GameObject.FindWithTag("Resource Holder");

        if (bullet == 1)
        {
            bulletDamage += resourceHolder.GetComponent<GameResources>().bulletExtraDamage;
        }
        if (bullet == 2)
        {
            bulletDamage += resourceHolder.GetComponent<GameResources>().bulletExtraDamage2;
        }


        rb = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        enemy = GameObject.FindWithTag("Enemy");

        Vector3 direction = enemy.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        direction.Normalize();
        movement = direction;

        if (resourceHolder.GetComponent<EnemySpawner>().enemyAmount <= 0)
        {
            Destroy(gameObject);
        }

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            collision.GetComponent<Enemy>().health -= bulletDamage;
            Destroy(gameObject);
        }


    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
