using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject resourceHolder;
    public GameObject enemy;

    public float moveSpeed = 5f;
    public float bulletDamage = 2;


    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
        resourceHolder = GameObject.FindWithTag("Resource Holder");

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
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            enemy.GetComponent<Enemy>().health -= bulletDamage;
            Destroy(gameObject);
        }


    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
