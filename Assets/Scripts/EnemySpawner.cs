using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int spawnLocation = 1;
    public int enemyAmount = 0;

    public float spawnCooldown = 4;
    public float spawnTimer = 4;

    public GameObject enemy1;

    public Transform spawnOne;
    public Transform spawnTwo;
    public Transform spawnThree;
    public Transform spawnFour;
    public Transform spawnFive;
    public Transform spawnSix;
    public Transform spawnSeven;
    public Transform spawnEight;

    private void Start()
    {
        spawnCooldown = 0.1f;
    }

    void Update()
    {
        if (spawnCooldown > 0)
        {
            spawnCooldown -= Time.deltaTime;
        }

        if (spawnCooldown <= 0)
        {
            EnemySpawn();
            spawnCooldown = spawnTimer;
        }
    }

    public void EnemySpawn()
    {
        spawnLocation = Random.Range(1, 8);

        if (spawnLocation == 1)
        {
            Instantiate(enemy1, new Vector3(11 , 0, 0), Quaternion.identity);
        }
        if (spawnLocation == 2)
        {
            Instantiate(enemy1, new Vector3(-11, 0, 0), Quaternion.identity);
        }
        if (spawnLocation == 3)
        {
            Instantiate(enemy1, new Vector3(11, 8, 0), Quaternion.identity);
        }
        if (spawnLocation == 4)
        {
            Instantiate(enemy1, new Vector3(0, -8, 0), Quaternion.identity);
        }
        if (spawnLocation == 5)
        {
            Instantiate(enemy1, new Vector3(11, -8, 0), Quaternion.identity);
        }
        if (spawnLocation == 6)
        {
            Instantiate(enemy1, new Vector3(-11, -8, 0), Quaternion.identity);
        }
        if (spawnLocation == 7)
        {
            Instantiate(enemy1, new Vector3(11, 8, 0), Quaternion.identity);
        }
        if (spawnLocation == 8)
        {
            Instantiate(enemy1, new Vector3(-11, 8, 0), Quaternion.identity);
        }
    }
}
