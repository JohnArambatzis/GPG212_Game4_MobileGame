using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResources : MonoBehaviour
{
    public float timer = 0;

    public float weakEnemyExtraHealth = 0;
    public float enemyExtraHealth = 0;
    public float bossExtraHealth = 0;
    public float enemyExtraGold = 0;

    public float bulletExtraDamage = 0;
    public float bulletDamageUpgradeAmount = 2;
    public float bulletExtraDamage2 = 0;
    public float bulletDamageUpgradeAmount2 = 1;

    public float bulletUpgradeDamgeCost = 2;
    public TextMeshProUGUI bulletUpgradeDamageCostText;

    public float bullet2UnlockCost = 20;
    public TextMeshProUGUI bullet2UnlockCostText;
    public GameObject bullet2UnlockUpgrade;

    public float bullet2UpgradeCost = 8;
    public TextMeshProUGUI bullet2UpgradeCostText;
    public GameObject bullet2DamageUpgrade;

    public GameObject player;


    void Start()
    {
        
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        weakEnemyExtraHealth = timer * 0.1f;
        enemyExtraHealth = timer * 0.25f;
        enemyExtraGold = timer * 0.06f;
        bossExtraHealth = timer * 0.4f;
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

    public void Bullet2Unlock()
    {
        if (player.GetComponent<Player>().gold >= bullet2UnlockCost)
        {
            player.GetComponent<Player>().bullet2Unlocked = true;
            player.GetComponent<Player>().gold -= bullet2UnlockCost;

            player.GetComponent<Player>().updateVariables = true;
            bullet2UnlockCostText.text = bullet2UnlockCost.ToString("0");
            bullet2UnlockUpgrade.SetActive(false);
            bullet2DamageUpgrade.SetActive(true);

        }
    }

    public void Bullet2Upgrade()
    {
        if (player.GetComponent<Player>().gold >= bullet2UpgradeCost)
        {
            player.GetComponent<Player>().gold -= bullet2UpgradeCost;
            bulletExtraDamage2 += bulletDamageUpgradeAmount2;
            bullet2UpgradeCost *= 2f;
            player.GetComponent<Player>().updateVariables = true;
            bullet2UpgradeCostText.text = bullet2UpgradeCost.ToString("0");

        }
    }

}
