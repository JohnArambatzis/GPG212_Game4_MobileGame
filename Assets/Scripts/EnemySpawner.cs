using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float gameLength = 0;

    public int spawnLocation = 1;
    public int enemyAmount = 0;

    public float spawnCooldown1 = 4;
    public float spawnTimer1 = 4;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;

    public Transform spawnOne;
    public Transform spawnTwo;
    public Transform spawnThree;
    public Transform spawnFour;
    public Transform spawnFive;
    public Transform spawnSix;
    public Transform spawnSeven;
    public Transform spawnEight;

    public bool secondMonster = false;
    public bool secondMonsterSpawn = false;
    public float spawnCooldown2 = 6;
    public float spawnTimer2 = 6;

    public bool thirdMonster = false;
    public bool thirdMonsterSpawn = false;
    public float spawnCooldown3 = 15;
    public float spawnTimer3 = 15;

    public bool forthMonster = false;
    public bool forthMonsterSpawn = false;
    public float spawnCooldown4 = 2;
    public float spawnTimer4 = 2;

    private void Start()
    {
        spawnCooldown1 = 0.1f;
        spawnCooldown2 = 0.1f;
        spawnCooldown3 = 0.1f;
        spawnCooldown4 = 0.1f;
    }

    void Update()
    {
        gameLength += Time.deltaTime;

        if (spawnCooldown1 > 0)
        {
            spawnCooldown1 -= Time.deltaTime;
        }
        if (spawnCooldown1 <= 0)
        {
            EnemyOneSpawn();
            spawnCooldown1 = spawnTimer1;
        }
        

        if (gameLength >= 25 && secondMonster == false)
        {
            secondMonsterSpawn = true;
            secondMonster = true;
        }
        if (secondMonsterSpawn == true && spawnCooldown2 > 0)
        {
            spawnCooldown2 -= Time.deltaTime;
        }
        if (spawnCooldown2 <= 0)
        {
            EnemyTwoSpawn();
            spawnCooldown2 = spawnTimer2;
        }


        if (gameLength >= 60 && thirdMonster == false)
        {
            thirdMonsterSpawn = true;
            thirdMonster = true;
        }
        if (thirdMonsterSpawn == true && spawnCooldown3 > 0)
        {
            spawnCooldown3 -= Time.deltaTime;
        }
        if (spawnCooldown3 <= 0)
        {
            EnemyThreeSpawn();
            spawnCooldown3 = spawnTimer3;
        }

        if (gameLength >= 100 && forthMonster == false)
        {
            forthMonsterSpawn = true;
            forthMonster = true;
        }
        if (forthMonsterSpawn == true && spawnCooldown4 > 0)
        {
            spawnCooldown4 -= Time.deltaTime;
        }
        if (spawnCooldown4 <= 0)
        {
            EnemyFourSpawn();
            spawnCooldown4 = spawnTimer4;
        }

    }

    #region Enemy 1
    public void EnemyOneSpawn()
    {
        spawnLocation = Random.Range(1, 8);

        if (spawnLocation == 1)
        {
            Instantiate(enemy1, new Vector3(spawnOne.position.x, spawnOne.position.y, spawnOne.position.z), Quaternion.identity);
        }
        if (spawnLocation == 2)
        {
            Instantiate(enemy1, new Vector3(spawnTwo.position.x, spawnTwo.position.y, spawnTwo.position.z), Quaternion.identity);
        }
        if (spawnLocation == 3)
        {
            Instantiate(enemy1, new Vector3(spawnThree.position.x, spawnThree.position.y, spawnThree.position.z), Quaternion.identity);
        }
        if (spawnLocation == 4)
        {
            Instantiate(enemy1, new Vector3(spawnFour.position.x, spawnFour.position.y, spawnFour.position.z), Quaternion.identity);
        }
        if (spawnLocation == 5)
        {
            Instantiate(enemy1, new Vector3(spawnFive.position.x, spawnFive.position.y, spawnFive.position.z), Quaternion.identity);
        }
        if (spawnLocation == 6)
        {
            Instantiate(enemy1, new Vector3(spawnSix.position.x, spawnSix.position.y, spawnSix.position.z), Quaternion.identity);
        }
        if (spawnLocation == 7)
        {
            Instantiate(enemy1, new Vector3(spawnSeven.position.x, spawnSeven.position.y, spawnSeven.position.z), Quaternion.identity);
        }
        if (spawnLocation == 8)
        {
            Instantiate(enemy1, new Vector3(spawnEight.position.x, spawnEight.position.y, spawnEight.position.z), Quaternion.identity);
        }
    }
    #endregion

    #region Enemy 2
    public void EnemyTwoSpawn()
    {
        spawnLocation = Random.Range(1, 8);

        if (spawnLocation == 1)
        {
            Instantiate(enemy2, new Vector3(spawnOne.position.x, spawnOne.position.y, spawnOne.position.z), Quaternion.identity);
        }
        if (spawnLocation == 2)
        {
            Instantiate(enemy2, new Vector3(spawnTwo.position.x, spawnTwo.position.y, spawnTwo.position.z), Quaternion.identity);
        }
        if (spawnLocation == 3)
        {
            Instantiate(enemy2, new Vector3(spawnThree.position.x, spawnThree.position.y, spawnThree.position.z), Quaternion.identity);
        }
        if (spawnLocation == 4)
        {
            Instantiate(enemy2, new Vector3(spawnFour.position.x, spawnFour.position.y, spawnFour.position.z), Quaternion.identity);
        }
        if (spawnLocation == 5)
        {
            Instantiate(enemy2, new Vector3(spawnFive.position.x, spawnFive.position.y, spawnFive.position.z), Quaternion.identity);
        }
        if (spawnLocation == 6)
        {
            Instantiate(enemy2, new Vector3(spawnSix.position.x, spawnSix.position.y, spawnSix.position.z), Quaternion.identity);
        }
        if (spawnLocation == 7)
        {
            Instantiate(enemy2, new Vector3(spawnSeven.position.x, spawnSeven.position.y, spawnSeven.position.z), Quaternion.identity);
        }
        if (spawnLocation == 8)
        {
            Instantiate(enemy2, new Vector3(spawnEight.position.x, spawnEight.position.y, spawnEight.position.z), Quaternion.identity);
        }
    }
    #endregion

    #region Enemy 3
    public void EnemyThreeSpawn()
    {
        spawnLocation = Random.Range(1, 8);

        if (spawnLocation == 1)
        {
            Instantiate(enemy3, new Vector3(spawnOne.position.x, spawnOne.position.y, spawnOne.position.z), Quaternion.identity);
        }
        if (spawnLocation == 2)
        {
            Instantiate(enemy3, new Vector3(spawnTwo.position.x, spawnTwo.position.y, spawnTwo.position.z), Quaternion.identity);
        }
        if (spawnLocation == 3)
        {
            Instantiate(enemy3, new Vector3(spawnThree.position.x, spawnThree.position.y, spawnThree.position.z), Quaternion.identity);
        }
        if (spawnLocation == 4)
        {
            Instantiate(enemy3, new Vector3(spawnFour.position.x, spawnFour.position.y, spawnFour.position.z), Quaternion.identity);
        }
        if (spawnLocation == 5)
        {
            Instantiate(enemy3, new Vector3(spawnFive.position.x, spawnFive.position.y, spawnFive.position.z), Quaternion.identity);
        }
        if (spawnLocation == 6)
        {
            Instantiate(enemy3, new Vector3(spawnSix.position.x, spawnSix.position.y, spawnSix.position.z), Quaternion.identity);
        }
        if (spawnLocation == 7)
        {
            Instantiate(enemy3, new Vector3(spawnSeven.position.x, spawnSeven.position.y, spawnSeven.position.z), Quaternion.identity);
        }
        if (spawnLocation == 8)
        {
            Instantiate(enemy3, new Vector3(spawnEight.position.x, spawnEight.position.y, spawnEight.position.z), Quaternion.identity);
        }
    }
    #endregion

    #region Enemy 4
    public void EnemyFourSpawn()
    {
        spawnLocation = Random.Range(1, 8);

        if (spawnLocation == 1)
        {
            Instantiate(enemy4, new Vector3(spawnOne.position.x, spawnOne.position.y, spawnOne.position.z), Quaternion.identity);
        }
        if (spawnLocation == 2)
        {
            Instantiate(enemy4, new Vector3(spawnTwo.position.x, spawnTwo.position.y, spawnTwo.position.z), Quaternion.identity);
        }
        if (spawnLocation == 3)
        {
            Instantiate(enemy4, new Vector3(spawnThree.position.x, spawnThree.position.y, spawnThree.position.z), Quaternion.identity);
        }
        if (spawnLocation == 4)
        {
            Instantiate(enemy4, new Vector3(spawnFour.position.x, spawnFour.position.y, spawnFour.position.z), Quaternion.identity);
        }
        if (spawnLocation == 5)
        {
            Instantiate(enemy4, new Vector3(spawnFive.position.x, spawnFive.position.y, spawnFive.position.z), Quaternion.identity);
        }
        if (spawnLocation == 6)
        {
            Instantiate(enemy4, new Vector3(spawnSix.position.x, spawnSix.position.y, spawnSix.position.z), Quaternion.identity);
        }
        if (spawnLocation == 7)
        {
            Instantiate(enemy4, new Vector3(spawnSeven.position.x, spawnSeven.position.y, spawnSeven.position.z), Quaternion.identity);
        }
        if (spawnLocation == 8)
        {
            Instantiate(enemy4, new Vector3(spawnEight.position.x, spawnEight.position.y, spawnEight.position.z), Quaternion.identity);
        }
    }
    #endregion
}
