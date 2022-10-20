using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResources : MonoBehaviour
{
    public float timer = 0;
    public float enemyExtraHealth = 0;
    public float bossExtraHealth = 0;
    public float enemyExtraGold = 0;

    public float bulletExtraDamage = 0;
    public float bulletDamageUpgradeAmount = 2;

    public float bulletUpgradeDamgeCost = 2;
    public TextMeshProUGUI bulletUpgradeDamageCostText;

    public GameObject player;


    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        enemyExtraHealth = timer * 0.1f;
        enemyExtraGold = timer * 0.02f;

        bossExtraHealth = timer;
    }

    public void BulletUpgradeDamage()
    {
        if (player.GetComponent<Player>().gold >= bulletUpgradeDamgeCost)
        {
            bulletExtraDamage += bulletDamageUpgradeAmount;
            player.GetComponent<Player>().gold -= bulletUpgradeDamgeCost;
            bulletUpgradeDamgeCost *= 2f;

            player.GetComponent<Player>().updateVariables = true;
            bulletUpgradeDamageCostText.text = bulletUpgradeDamgeCost.ToString("0");
        }
    }
}
