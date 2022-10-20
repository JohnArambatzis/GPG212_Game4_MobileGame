using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float health = 50;
    public TextMeshProUGUI healthAmountText;

    public float gold = 0;
    public TextMeshProUGUI goldAmountText;

    public float score = 0;
    public TextMeshProUGUI scoreText;

    public GameObject player;
    public GameObject resourceHolder;
    public GameObject bullet;
    public GameObject bullet2;
    public Transform weaponSpawn;

    public float bulletCooldown = 2f;
    public float bulletTimer = 2;

    public bool bullet2Unlocked = false;
    public float bullet2Cooldown = 0.5f;
    public float bullet2Timer = 0.5f;


    public bool updateVariables = false;

    public GameObject gameOverPanel;

    void Update()
    {
        if (health <= 0)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

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

        if (bullet2Unlocked == true)
        {
            if (bullet2Cooldown > 0)
            {
                bullet2Cooldown -= Time.deltaTime;
            }
            if (resourceHolder.GetComponent<EnemySpawner>().enemyAmount > 0)
            {
                if (bullet2Cooldown <= 0)
                {
                    Instantiate(bullet2, new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z), Quaternion.identity);

                    bullet2Cooldown = bullet2Timer;
                }
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
        goldAmountText.text = gold.ToString("0.0");
        scoreText.text = score.ToString("0");
    }


    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
