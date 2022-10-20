using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float health = 50;
    public TextMeshProUGUI healthAmountText;

    public float gold = 0;
    public TextMeshProUGUI goldAmountText;

    public GameObject player;
    public GameObject resourceHolder;
    public GameObject bullet;
    public Transform weaponSpawn;
    public float bulletCooldown = 2f;
    public float bulletTimer = 2;

    public bool updateVariables = false;

    void Update()
    {
        if (bulletCooldown > 0)
        {
            bulletCooldown -= Time.deltaTime;
        }
        if (resourceHolder.GetComponent<EnemySpawner>().enemyAmount > 0)
        {
            if (bulletCooldown <= 0)
            {
                Instantiate(bullet, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);

                bulletCooldown = bulletTimer;
            }
        }


        if (updateVariables == true)
        {
            UpdateVariables();
            updateVariables = false;
        }
    }


    public void UpdateVariables()
    {
        healthAmountText.text = health.ToString("0");
        goldAmountText.text = gold.ToString("0");
    }
}
